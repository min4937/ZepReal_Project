using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneLoadManager : MonoBehaviour
{
    
    static SceneLoadManager sceneManager;

    public static SceneLoadManager Instance
    {
        get { return sceneManager; }
    }

    private void Awake()
    {
        sceneManager = this;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

}
