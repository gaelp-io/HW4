using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float flapForce = 5f;
    public AudioClip flapSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flap();
        }
    }

    void Flap()
    {
        rb.velocity = Vector2.zero; 
        rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);

        audioSource.PlayOneShot(flapSound);
    }
}
