using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelathController : MonoBehaviour
{
    Transform []heart;
    int index = 1;

    void Start()
    {
        heart = transform.GetComponentsInChildren<Transform>(true);
        if (heart != null)
        {
            Debug.Log("aaa");
        }
    }

    public void Attacked(int over_num)
    {
        if(index <= 3)
        {
            Debug.Log("ダメージを食らいました");
            heart[index].gameObject.SetActive(false);
            //heart[index].GetComponent<Image>().enabled = false;
            index++;

        }
        if (index >= 4) 
        { 
            if (over_num == 1)
            {
                SceneManager.LoadScene("GameOverIka");
            }
            else if(over_num == 2) 
            {
                SceneManager.LoadScene("GameOverApple");
            }
            else if (over_num == 3)
            {
                SceneManager.LoadScene("GameOverSnow");
            }
            else if (over_num == 4)
            {
                SceneManager.LoadScene("GameOverMush");
            }
        }
    }
    public void HPGain()
    {
        if (index >= 2 && index <= 3)
        {
            Debug.Log("HPGain");
            heart[index-1].gameObject.SetActive(true);
            //heart[index-1].GetComponent<Image>().enabled = true;
            index--;

        }
    }
}
