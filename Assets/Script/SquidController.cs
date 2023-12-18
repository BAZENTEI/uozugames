using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidController : MonoBehaviour
{
    //�X���C���̓������w��
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

        //�����]��
        if (direction == "right")
        {
            transform.localScale = new Vector2(-1, 1);

        }

        defPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�����]���̏���
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
        //�����ړ�
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
    //�I�u�W�F�N�g�ɓ��������Ƃ��ɋN��
    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        //�v���C���[�ɓ���������v���C���[�����S
        if (collision.gameObject.tag == "Player")
        {
            //������HP�Ǘ��̃��]�b�g���Ă�
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
