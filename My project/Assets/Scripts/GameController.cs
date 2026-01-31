using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public bool isGameOver = false;

    public int score = 0;

    public event Action<int> OnScoreChanged;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void AddScore(int amount = 1)
    {
        if (isGameOver) return; // Don't add points after death

        score += amount;

        OnScoreChanged?.Invoke(score);

        Debug.Log("Score increased to: " + score);
    }
}
