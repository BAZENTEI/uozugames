using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallRide : MonoBehaviour
{
    float Changescale = 0.0006f;
    float maxScale = 4.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CircleCollider2D circleCollider2D = GetComponent<CircleCollider2D>();
        if (circleCollider2D != null)
        {
            if (circleCollider2D.transform.rotation != Quaternion.identity)
            {
                InvokeRepeating("ChangeScale", 0, 0.7f);
            }
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
            collision.transform.SetParent(transform);

        }
    }
}
