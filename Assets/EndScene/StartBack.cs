using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBack : MonoBehaviour
{
    public void ButtonOnClick()
    {
        SceneManager.LoadScene("Start");
        Destroy(transform.GetChild(0).gameObject);
    }
}
