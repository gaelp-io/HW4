using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
            GameController.Instance.OnScoreChanged += UpdateScore;
            UpdateScore(GameController.Instance.score);
    }

    void OnDestroy()
    {
        if (GameController.Instance != null)
            GameController.Instance.OnScoreChanged -= UpdateScore;
    }

    void UpdateScore(int newScore)
    {
        if (scoreText != null)
            scoreText.text = "Points: " + newScore;
    }
}