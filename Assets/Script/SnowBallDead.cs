using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallDead : MonoBehaviour
{
    float Changescale = 0.0006f;
    float maxScale = 4.0f;
    public bool TF = false;
    Rigidbody rb;
    bool TouchPlayer;
    public HelathController helathController;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        helathController = FindObjectOfType<HelathController>();
    }

    // Update is called once per frame
    void Update()
    {
        CircleCollider2D circleCollider2D = GetComponent<CircleCollider2D>();

        if (TF && rb!=null)
        {
            rb.isKinematic = false;
        }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            helathController.Attacked(3);
        }
    }

   
}
