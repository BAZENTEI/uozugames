using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGene : MonoBehaviour
{
    public GameObject GameObject;
    float posiX1 = 44.36f;
    float posiX2 = 50.51f;
    float posiX3 = 56.74f;
    float posiX4 = 63.58f;
    float posiX5 = 70.49f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Gene1",0,1);
        InvokeRepeating("Gene2",0,1.5f);
        InvokeRepeating("Gene3",0,1);
        InvokeRepeating("Gene4",0,1.3f);
        InvokeRepeating("Gene5",0,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gene1()
    {
        Instantiate(GameObject, new Vector3(posiX1, transform.position.y,0), Quaternion.identity);
    }
    void Gene2()
    {
        Instantiate(GameObject, new Vector3(posiX2, transform.position.y, 0), Quaternion.identity);
    }
    void Gene3()
    {
        Instantiate(GameObject, new Vector3(posiX3, transform.position.y, 0), Quaternion.identity);
    }
    void Gene4()
    {
        Instantiate(GameObject, new Vector3(posiX4, transform.position.y, 0), Quaternion.identity);
    }
    void Gene5()
    {
        Instantiate(GameObject, new Vector3(posiX5, transform.position.y, 0), Quaternion.identity);
    }
}
