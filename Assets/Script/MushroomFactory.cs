using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomFactory : MonoBehaviour
{
    GameObject Poisen;
    GameObject Basic;
    float deltaTimePurple = 0.0f;
    float deltaTimeRed = 0.0f;
    public float spanTimePurple = 1.0f;
    public float spanTimeRed = 1.0f;
    public Vector3 minPosition, maxPosition;
    // Start is called before the first frame update
    void Start()
    {
        Poisen = Resources.Load<GameObject>("poisonous-mushroom");
        Basic = Resources.Load<GameObject>("Basic-mushroom");
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimePurple += Time.deltaTime;
        deltaTimeRed += Time.deltaTime;
        if (deltaTimePurple > spanTimePurple)
        {

            Vector3 randomPostion = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), 0);
            //purple
            Instantiate<GameObject>(Poisen, randomPostion, Quaternion.identity);
            Debug.Log("purple apple creat");
            deltaTimePurple = 0.0f;
        }

        if (deltaTimeRed > spanTimeRed)
        {
            //red
            Vector3 randomPostionRed = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), 0);
            Instantiate<GameObject>(Basic, randomPostionRed, Quaternion.identity);
            Debug.Log("red apple creat");
            deltaTimeRed = 0.0f;
        }
    }
}
