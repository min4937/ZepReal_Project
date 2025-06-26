using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager gameManager;

    public static MiniGameManager Instance => gameManager;

    public int currentScore = 0;
    MiniGameUIManager uiManager;

    public MiniGameUIManager UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<MiniGameUIManager>();
    }

    private void Start()
    {
        if (UIManager != null)
        {
            UIManager.UpdateScore(0);
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        if (UIManager != null)
        {
            UIManager.GameOver();
        }

        if (PlayerPrefs.HasKey("BestScore"))
        {
            var oldScore = PlayerPrefs.GetInt("BestScore");
            if (oldScore < currentScore)
            {
                PlayerPrefs.SetInt("BestScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
        }

        if (UIManager != null)
        {
            UIManager.DisplayRanking(PlayerPrefs.GetInt("BestScore"));
        }
    }

    public void AddScore(int score)
    {
        currentScore += score;
        if (UIManager != null)
        {
            UIManager.UpdateScore(currentScore);
        }
        Debug.Log("Score: " + currentScore);
    }
}