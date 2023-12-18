using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    [SerializeField] float upspeed;
    [SerializeField] float downspeed;
    bool up;
    float uplimmit = 4.16f;
    float bottomlimmit = -3.38f;

     void Start()
    {
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            upspeed = 0.05f;
            transform.Translate(0, upspeed, 0);
            if(transform.position.y > uplimmit)
            {
                upspeed = 0;
                up = false;
            }
        }
        if(up == false)
        {
            downspeed = 0.05f;
            transform.Translate(0,-downspeed, 0);
            if(transform.position .y < bottomlimmit)
            {
                downspeed = 0;
                up = true;
            }
        }
    }
}
