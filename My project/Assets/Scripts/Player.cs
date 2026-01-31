using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flapForce = 5f;
    public AudioClip flapSound;
    public AudioClip hitSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private bool isAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!isAlive) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flap();
        }
    }

    void Flap()
    {
        if (!isAlive) return;

        rb.velocity = Vector2.zero;
        rb.AddForce(Vector3.up * flapForce, ForceMode2D.Impulse);

        audioSource.PlayOneShot(flapSound);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isAlive) return;

        if (collision.gameObject.CompareTag("Pipe"))
        {
            isAlive = false;

            audioSource.PlayOneShot(hitSound);

            Debug.Log("Game Over! Hit a pipe.");

            GameController.Instance.isGameOver = true;

            PipeMover[] pipes = FindObjectsOfType<PipeMover>();
            foreach (PipeMover pipe in pipes)
            {
                Destroy(pipe.gameObject);
            }
        }
    }
}