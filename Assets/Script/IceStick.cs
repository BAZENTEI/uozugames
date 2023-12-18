using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceStick : MonoBehaviour
{
    bool up = false;
    [SerializeField] float Upspeed = 0.06f;
    [SerializeField] float DownSpeed = 0.007f;
    public HelathController helathController;
    // Start is called before the first frame update
    void Start()
    {
        helathController = FindObjectOfType<HelathController>();
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            Upspeed = 0.06f;
            transform.Translate(0, Upspeed, 0);
            if(transform.position.y > -0.15f)
            {
                Upspeed = 0;
                up = false;
            }
        }
        if(up == false)
        {
            DownSpeed = 0.007f;
            transform.Translate(0,-DownSpeed, 0);
            if(transform.position.y < -8.14f)
            {
                    DownSpeed = 0;
                    up = true;
               
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            helathController.Attacked(1);
        }
    }
}
