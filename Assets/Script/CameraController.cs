using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float leftLimit;
    [SerializeField] float rightLimit;
    [SerializeField] float topLimit;
    [SerializeField] float bottomLimit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if(player != null)
        {
           
            float x = player.transform.position.x +6;
            float y = player.transform.position.y;
            float z = transform.position.z;

            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if(x > rightLimit)
            {
                x = rightLimit;
            }

            if(y > topLimit)
            {
                y = topLimit;
            }
            else if(y < bottomLimit)
            {
                y = bottomLimit;
            }

            Vector3 vector3 = new Vector3(x, y, z);
            transform.position = vector3;
        }
       
    }
}
