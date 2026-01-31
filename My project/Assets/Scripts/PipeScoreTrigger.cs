using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScoreTrigger : MonoBehaviour
{
    public AudioClip scoreSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.Instance.AddScore();

            // Play score sound
            if (collision.GetComponent<AudioSource>() != null && scoreSound != null)
            {
                collision.GetComponent<AudioSource>().PlayOneShot(scoreSound);
            }

            // Destroy the trigger so it can't score twice
            Destroy(gameObject);
        }
    }
}

