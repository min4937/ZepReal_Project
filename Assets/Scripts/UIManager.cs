using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button[] buttons;
    public TextMeshProUGUI bestScoreText;

    public TextMeshProUGUI passText;
    public TextMeshProUGUI failText;

    private void Start()
    {
        // 초기에는 텍스트 비활성화
        if (passText != null) passText.gameObject.SetActive(false);
        if (failText != null) failText.gameObject.SetActive(false);
    }
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
        DisplayResult();
    }
    void DisplayResult()
    {
        if (GameManager.Instance.currentScore >= 20)
        {
            if (passText != null) passText.gameObject.SetActive(true);
            if (failText != null) failText.gameObject.SetActive(false);
        }
        else
        {
            if (passText != null) passText.gameObject.SetActive(false);
            if (failText != null) failText.gameObject.SetActive(true);
        }
    }


    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}

