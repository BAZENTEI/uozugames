using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    [SerializeField]
    float Changescale = 0.0005f;
    [SerializeField]
    float maxScale = 2.0f;
    bool TouchPlayer;
    Transform myTransform;
    void Start()
    {
        myTransform = transform;
        TouchPlayer = false;
    }


    void Update()
    {
        CircleCollider2D circleCollider2D = GetComponent<CircleCollider2D>();
        if (circleCollider2D != null)
        {
            if (circleCollider2D.transform.rotation != Quaternion.identity && TouchPlayer == true)
            {
                InvokeRepeating("ChangeScale", 0, 0.7f);
            }
            //else if(circleCollider2D.transform.rotation != Quaternion.identity)
            //{
            //    InvokeRepeating("ChangeScale", 0, 0.7f);
            //}
            else
            {
                CancelInvoke("ChangeScale");
            }
        }
       
    }

    void ChangeScale()
    {
        Vector3 CurrentScale = transform.localScale;
        CurrentScale += new Vector3(Changescale, Changescale, 0);
        CurrentScale = Vector3.Min(CurrentScale, new Vector3(maxScale, maxScale, maxScale));
        transform.localScale = CurrentScale;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TouchPlayer = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TouchPlayer = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ice" && myTransform.localScale.x >= 3f && myTransform.localScale.y >= 3f)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
