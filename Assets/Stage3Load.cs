using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3Load : MonoBehaviour
{
    //stage3�̖��O��""�̒��ɓ���Ă�
    public void ButtonOnClick()
    {
        SceneManager.LoadScene("Stage2");
        PlayerPrefs.SetInt("ClearedStage", 2);

    }
}
