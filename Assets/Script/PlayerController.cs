using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    public string stopanime = "StopAnimation";
    public string moveanime = "MoveAnimation";
    [SerializeField]
    private float Speed;
    private float MoveX;
    private Rigidbody2D rb;
    [SerializeField]
    private float JumpPower;
    public LayerMask GroundLayer;
    [SerializeField]
    private float GroundDistance;
    bool isMove = false;
    bool isJump = false;

    private HelathController helathController;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.Play(stopanime);

        helathController = GameObject.Find("Canvas/Panel/Health").GetComponent<HelathController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isGround = isGrounded();
        Debug.Log(isGround);
       //‰¡ˆÚ“®
        MoveX = Input.GetAxis("Horizontal");
        if(MoveX > 0)
        {
            isMove = true;
            rb.velocity = new Vector2(Speed * MoveX, rb.velocity.y);
        }
        else if(MoveX < 0)
        {
            isMove = true;
            rb.velocity = new Vector2(Speed * MoveX, rb.velocity.y);
        }
        else
        {
            isMove = false;
            rb.velocity = new Vector2(0,rb.velocity.y);
        }

        //cˆÚ“®
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJump = true;
                rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            }
            else
            {
                isJump = false;
            }
        }

        if(isGround && isMove == false)
        {
            anim.Play(stopanime);
        }
        else
        {
            anim.Play(moveanime);
        }

        
    }
    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, GroundDistance, GroundLayer);
        return hit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FallDead")
        {
            SceneManager.LoadScene("FailEnd");
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Squid" || collision.gameObject.tag == "Hotaruika")
        {
            helathController.Attacked(1);
        }
        if (collision.gameObject.tag == "MoveSquid")
        {
            helathController.Attacked(1);
        }
    }
}
