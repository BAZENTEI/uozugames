using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stag3ClearButtonController : MonoBehaviour
{
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonOnClick()
    {

        SceneManager.LoadScene("End");
    }
}
