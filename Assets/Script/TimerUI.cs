using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Text timerText;
    public Timer timer;

    void Update()
    {
        UpdateTimerUI();
    }

    void UpdateTimerUI()
    {
        if (timerText != null && timer != null)
        {
            timerText.text = "Time: " + timer.GetElapsedTime().ToString("F2"); // F2�͏����_�ȉ�2���܂ŕ\��
        }
    }
}
