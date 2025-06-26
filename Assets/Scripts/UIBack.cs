using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIBack : MonoBehaviour
{
    public TextMeshProUGUI passText;
    public TextMeshProUGUI falseText; // It might be "failText"

    MiniGameUIManager manager;

    // This method needs an implementation.
    public void DisPlaySet(MiniGameManager gameManager)
    {
        // Example: if(gameManager.currentScore > 10) ...
    }
}