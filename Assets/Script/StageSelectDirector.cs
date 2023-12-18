using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectDirector : MonoBehaviour
{
    public int clearedStage = 0;
    GameObject[] go;
    void Start()
    {


        PlayerPrefs.SetInt("ClearedStage", 0);
        PlayerPrefs.Save();
        Debug.Log("Start:" + clearedStage);

        go = GameObject.FindGameObjectsWithTag("StageChooseButton");
        Debug.Log(go[0].name);

        for (int i = 0; i < go.Length; i++)
        {
            if (i < clearedStage + 1)
            {
                go[i].SetActive(true);
            }
            else
            {
                go[i].SetActive(false);
            }
           
        }
        clearedStage = PlayerPrefs.GetInt("ClearedStage", 0);
        //Debug.Log("Start2:" + PlayerPrefs.GetInt("ClearedStage", 1));
        
        
        


        //Debug.Log("Start3:" + PlayerPrefs.GetInt("ClearedStage", 1));

    }

    void Update()
    {
        
    }
}
