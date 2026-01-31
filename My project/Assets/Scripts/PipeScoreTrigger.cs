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

            collision.GetComponent<AudioSource>().PlayOneShot(scoreSound);
            
            Destroy(gameObject);
        }
    }
}

