using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Timer timer;

    void Start()
    {
        // ゲームが開始されたらタイマーをスタート
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
        // ゴールに到達したらタイマーをストップ
        if (timer != null)
        {
            timer.StopTimer();
            // ハイスコアを保存
            HighScoreManager.SaveHighScore((int)timer.GetElapsedTime());
        }

    }
    
}
