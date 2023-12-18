using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public static int highScore;
   
    void Start()
    {
        // ゲーム開始時にハイスコアをロード
        LoadHighScore();
    }

    public static void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            // PlayerPrefsにハイスコアを保存
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    void LoadHighScore()
    {
        // PlayerPrefsからハイスコアをロード
        highScore = PlayerPrefs.GetInt("HighScore", 0);
      

    }
}
