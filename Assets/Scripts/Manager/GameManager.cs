using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerController player { get; private set; }
    private ResourceController _playerResourceController;

    [SerializeField] private int currentWaveIndex = 0;

    private EnemyManager enemyManager;

    private UIManager uiManager;
    public static bool IsFirstLoading = true;

    private void Awake()
    {
        instance = this;
        player = FindObjectOfType<PlayerController>();
        if (player != null)
            player.Init(this);

        uiManager = FindObjectOfType<UIManager>();

        enemyManager = GetComponentInChildren<EnemyManager>();
        if (enemyManager != null)
            enemyManager.Init(this);

        if (player != null)
        {
            _playerResourceController = player.GetComponent<ResourceController>();
            // Remove previous to be safe, then add the new one.
            _playerResourceController.RemoveHealthChangeEvent(uiManager.ChangePlayerHP);
            _playerResourceController.AddHealthChangeEvent(uiManager.ChangePlayerHP);
        }

    }

    private void Start()
    {
        if (!IsFirstLoading)
        {
            StartGame();
        }
        else
        {
            IsFirstLoading = false;
        }
    }
    public void StartGame()
    {
        currentWaveIndex = 0;
        uiManager.SetPlayGame();
        StartNextWave();
    }

    void StartNextWave()
    {
        currentWaveIndex += 1;
        enemyManager.StartWave(1 + currentWaveIndex / 5);
        uiManager.ChangeWave(currentWaveIndex);
    }

    public void EndOfWave()
    {
        StartNextWave();
    }

    public void GameOver()
    {
        enemyManager.StopWave();
        uiManager.SetGameOver();
    }
}


