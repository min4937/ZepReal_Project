using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpDown : MonoBehaviour
{
    public GameObject passText;
    public GameObject failText;
    // Start is called before the first frame update
    void Start()
    {
        
        if (!PlayerPrefs.HasKey("BestScore"))
        {
            return;
        }

        if(PlayerPrefs.GetInt("BestScore") >5)
        {
            passText.SetActive(true);
        }
        else
        {
            failText.SetActive(true);
        }
        StartCoroutine(TimeOut());
    }

    IEnumerator TimeOut()
    {
        yield return new WaitForSeconds(3f);
        failText.SetActive(false);
        passText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
