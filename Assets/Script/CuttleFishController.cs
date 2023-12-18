using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttleFishController : MonoBehaviour
{
    public GameObject InkPrefab;
    [SerializeField] Transform SpawnPoint;
    Quaternion SpawnRotation = Quaternion.Euler(0, 0, 180);
    [SerializeField] float span;
    void Start()
    {
        InvokeRepeating("GeneratetInk", 0, span);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GeneratetInk()
    {
        GameObject Generator = Instantiate(InkPrefab,SpawnPoint.position,SpawnRotation);
    }
}
