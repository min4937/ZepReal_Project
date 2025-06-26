using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button[] buttons;
    public TextMeshProUGUI bestScoreText;

    MiniGameManager gameManager;

    public void DisplayRanking(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }
    public void GameOver()
    {
        bestScoreText.gameObject.SetActive(true);

        foreach (var button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}