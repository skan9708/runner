using UnityEngine;
using System.Collections;

public class Knight : MonoBehaviour {

    public bool grounded = false;
    public int jumpspeed = 0;
    public int movespeed = 0;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }
    void OnCollisionEnter2D(Collision2D collidingObject)
    {
        if (collidingObject.gameObject.tag == "Ground")
        {
            anim.Play("knight_idle");
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collidingObject)
    {
        if (collidingObject.gameObject.tag == "Ground")
        {
            anim.Play("knight_jump");
            grounded = false;
        }
    }

    void Update () 
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 move = rb.velocity;

        // move : jump
        if (grounded && (Input.GetKey(KeyCode.UpArrow)))
        {
            move.y = jumpspeed;
        }
        // move : right & left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x = movespeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = -movespeed;
        }
        else
        {
            move.x = 0;
        }
        rb.velocity = move;

        // attack
        if (grounded && Input.GetKey(KeyCode.Space) && anim.GetCurrentAnimatorStateInfo(0).IsName("knight_idle"))
        {
            anim.Play("knight_attack", -1, 100);
        }

        // animation
        if (grounded && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
        {
            anim.Play("knight_walk");
        }
        if (grounded && (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)))
        {
            anim.Play("knight_idle");
        }

        // animation : left & right direct scale
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 direct = transform.localScale;
            direct.x = 1;
            transform.localScale = direct;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 direct = transform.localScale;
            direct.x = -1;
            transform.localScale = direct;
        }
    }
}
