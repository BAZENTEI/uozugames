using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Load : MonoBehaviour
{
    //stage2�̖��O��""�̒��ɓ���Ă�
    public void ButtonOnClick()
    {
        SceneManager.LoadScene("MainStage1");
        PlayerPrefs.SetInt("ClearedStage", 2);
    }
}
