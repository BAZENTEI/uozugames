using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSquidController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    Rigidbody2D rb;
    [SerializeField]
    private float Fallrange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            float dist = Vector2.Distance(this.transform.position, player.transform.position);
            if (dist < Fallrange)
            {
                Debug.Log("”ÍˆÍ“à‚É“ü‚è‚Ü‚µ‚½I");
                if (rb.bodyType == RigidbodyType2D.Kinematic)
                {
                    rb.bodyType = RigidbodyType2D.Dynamic;
                }
            }
        }
      
    }
}
