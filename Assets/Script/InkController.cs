using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkController : MonoBehaviour
{
    
    [SerializeField]
    float speed;
    public HelathController helathController;
    int over_num = 1;
    // Start is called before the first frame update
    void Start()
    {
        helathController = FindObjectOfType<HelathController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);
        if (transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SnowBall")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            helathController.Attacked(1);
        }
    }
    
}
