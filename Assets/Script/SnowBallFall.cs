using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallFall : MonoBehaviour
{
    [SerializeField]
    float speed;
    float rnd;
    public HelathController helathController;
    // Start is called before the first frame update
    void Start()
    {
        helathController = FindObjectOfType<HelathController>();
        rnd = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * rnd, 0);
        if(transform.position.y < -8.3f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            helathController.Attacked(3);
        }
    }
}
