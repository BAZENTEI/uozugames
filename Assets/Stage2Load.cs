using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Load : MonoBehaviour
{
    //stage2の名前を""の中に入れてね
    public void ButtonOnClick()
    {
        SceneManager.LoadScene("MainStage1");
        PlayerPrefs.SetInt("ClearedStage", 2);
    }
}
