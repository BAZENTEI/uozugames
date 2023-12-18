using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Timer timer;

    void Start()
    {
        // �Q�[�����J�n���ꂽ��^�C�}�[���X�^�[�g
        StartGame();
    }

    void StartGame()
    {
        if (timer != null)
        {
            timer.StartTimer();
        }
    }

    public void GoalReached()
    {
        // �S�[���ɓ��B������^�C�}�[���X�g�b�v
        if (timer != null)
        {
            timer.StopTimer();
            // �n�C�X�R�A��ۑ�
            HighScoreManager.SaveHighScore((int)timer.GetElapsedTime());
        }

    }
    
}
