using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour
{
   float fallspeedx;
   float fallspeedy;  
    float Rndrot;
    public LayerMask groundlayer;
    [SerializeField]
    private float GroundDistance;
    void Start()
    {
        fallspeedx = Random.Range(0.06f, 0.135f);
        fallspeedy = Random.Range(0.06f, 0.135f);
    }

   
    void Update()
    {
        bool isGround = isGrounded();
        transform.Translate(-fallspeedx, -fallspeedy, 0);

        if(isGround)
        {
            Destroy(gameObject);
        }
        if(transform.position.y < -6.3f)
        {
            Destroy(gameObject);
        }
        if(transform.position.x < -12.3)
        {
            Destroy(gameObject);
        }
    }

    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, GroundDistance, groundlayer);
        return hit.collider != null;
    }
}
