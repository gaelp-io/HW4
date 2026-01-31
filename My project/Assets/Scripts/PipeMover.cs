using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyX = -15f;

    void Update()
    {
        // Move left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy when off-screen
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
