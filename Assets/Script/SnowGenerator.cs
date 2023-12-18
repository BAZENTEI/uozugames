using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowGenerator : MonoBehaviour
{
    public GameObject SnowPrefab;
    [SerializeField] float leftlimit;
    [SerializeField] float rightlimit;
    public Camera maincamera;
    float geneRange = 10f;
    float inteval = 0.2f;
    float lastInvokeTime;
    float minX;
    float maxX;
    void Start()
    {
        InvokeRepeating("GenerateSnow", 0, 0.1f);
    }

   
    void Update()
    {
        float cameraX = maincamera.transform.position.x;

        minX = cameraX - geneRange / 2;
        maxX = cameraX + geneRange / 2;

        if (transform.position.x > minX && transform.position.x < maxX)
        {
            if(Time.time - lastInvokeTime > inteval)
            {
                GenerateSnow();
                lastInvokeTime = Time.time;
            }
        }
    }

    void GenerateSnow()
    {
        float rndx = Random.Range(minX, maxX + 10);
        Vector3 spawnpoosi = new Vector3(rndx, transform.position.y,0);
        Instantiate(SnowPrefab,spawnpoosi,Quaternion.identity);
    }
}
