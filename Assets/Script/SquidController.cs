using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidController : MonoBehaviour
{
    //スライムの動きを指定
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private string direction = "left";
    [SerializeField]
    private float range = 0f;
    Vector3 defPos;

    // Start is called before the first frame update
    void Start()
    {

        //方向転換
        if (direction == "right")
        {
            transform.localScale = new Vector2(-1, 1);

        }

        defPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //方向転換の条件
        if (range > 0f)
        {
            if (transform.position.x < defPos.x - (range / 2))
            {

                direction = "right";
                transform.localScale = new Vector2(-1, 1);
            }
            if (transform.position.x > defPos.x + (range / 2))
            {

                direction = "left";
                transform.localScale = new Vector2(1, 1);

            }
        }
    }

    void FixedUpdate()
    {
        //往復移動
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (direction == "right")
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //Debug.Log("right");
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            //Debug.Log("left");
        }
    }
    //オブジェクトに当たったときに起動
    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        //プレイヤーに当たったらプレイヤーが死亡
        if (collision.gameObject.tag == "Player")
        {
            //ここにHP管理のメゾットを呼ぶ
            if (direction == "right")
            {
                direction = "left";
                transform.localScale = new Vector2(1, 1);
            }
            else
            {
                direction = "right";
                transform.localScale = new Vector2(-1, 1);
            }
        }


    }
}
