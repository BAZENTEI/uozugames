using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public static int highScore;
   
    void Start()
    {
        // �Q�[���J�n���Ƀn�C�X�R�A�����[�h
        LoadHighScore();
    }

    public static void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            // PlayerPrefs�Ƀn�C�X�R�A��ۑ�
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    void LoadHighScore()
    {
        // PlayerPrefs����n�C�X�R�A�����[�h
        highScore = PlayerPrefs.GetInt("HighScore", 0);
      

    }
}
