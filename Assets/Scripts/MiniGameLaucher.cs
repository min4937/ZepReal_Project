using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameLaucher : MonoBehaviour
{
    private SceneLoader loader;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        loader.LoadScene();
    }

    private void Start()
    {
        loader = GetComponent<SceneLoader>(); 
    }
}
