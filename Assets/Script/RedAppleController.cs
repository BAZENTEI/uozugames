using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAppleController : MonoBehaviour
{
    public float ySpeed = -0.005f;


    void Update()
    {
        transform.Translate(new Vector3(0.0f, ySpeed, 0.0f));
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            HelathController healthUI = GameObject.Find("Health").GetComponent<HelathController>();
          
            healthUI.HPGain();

            Debug.Log("red apple player touch");

        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);

            Debug.Log("red apple wall touch");
        }

        Debug.Log("OnTriggerEnter2D Red");
    }

}
