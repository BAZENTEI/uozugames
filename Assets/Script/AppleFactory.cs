using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFactory : MonoBehaviour
{
    GameObject stoneGameObject;
    GameObject redApple;
    float deltaTimePurple = 0.0f;
    float deltaTimeRed = 0.0f;
    public float spanTimePurple = 1.0f;
    public float spanTimeRed = 1.0f;
    public Vector3 minPosition, maxPosition;
    void Start()
    {
        stoneGameObject = Resources.Load<GameObject>("PurpleApple");
        redApple = Resources.Load<GameObject>("RedApple");
        //stoneGameObject = GameObject.Find("stone");
        //Debug.Log(stoneGameObject.name);
    }

    void Update()
    {
        deltaTimePurple += Time.deltaTime;
        deltaTimeRed += Time.deltaTime;
        if (deltaTimePurple > spanTimePurple)
        {

            Vector3 randomPostion = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), 0);
            //purple
            Instantiate<GameObject>(stoneGameObject, randomPostion, Quaternion.identity);
            Debug.Log("purple apple creat");
            deltaTimePurple = 0.0f;
        }

        if (deltaTimeRed > spanTimeRed)
        {   
            //red
            Vector3 randomPostionRed = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), 0);
            Instantiate<GameObject>(redApple, randomPostionRed, Quaternion.identity);
            Debug.Log("red apple creat");
            deltaTimeRed = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        //Instantiate<GameObject>(stoneGameObject, new Vector3(0.0f, -0.01f, 0.0f), Quaternion.identity);
    }
}
