using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyX = -15f;

    void Update()
    {
        // Stop moving if game is over
        if (GameController.Instance != null && GameController.Instance.isGameOver)
            return;

        // Move left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy when off-screen
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If pipe touches the player after spawn, destroy itself
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

