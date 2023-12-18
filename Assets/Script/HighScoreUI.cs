using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        DisplayHighScore();
    }

    void DisplayHighScore()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "ƒ^ƒCƒ€: " + HighScoreManager.highScore;
        }
    }
}
