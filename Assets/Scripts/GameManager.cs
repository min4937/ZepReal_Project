using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    public int currentScore = 0;
    UIManager uiManager;

    public UIManager UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.GameOver();
        if (PlayerPrefs.HasKey("BestScore"))
        {            
            var oldScore = PlayerPrefs.GetInt("BestScore");
            if(oldScore < currentScore)
            {
                PlayerPrefs.SetInt("BestScore", currentScore);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
        }

        uiManager.DisplayRanking(PlayerPrefs.GetInt("BestScore"));
    }

    

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

}



