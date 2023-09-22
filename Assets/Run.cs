using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Run : MonoBehaviour {
    Animator anim;
    public float speed = 5f;
    public int state = 0;
    private Vector2 movement;
    private Rigidbody2D rb;
 
 
    // Use this for initialization
    void Start () {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = movement;
    }
   
    // Update is called once per frame
    void FixedUpdate () {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(inputX, inputY);

        transform.Translate(movement * speed * Time.deltaTime);
        // rb.MovePosition(movement * speed * Time.deltaTime);

        //Diagonals
 
        // if (inputX != 0 && inputY != 0) {
        //     if (movement.y == 1 && movement.x == -1)
        //     {
        //         anim.SetTrigger("move_up_left");
        //     }
 
        //     if (movement.y == 1 && movement.x == 1)
        //     {
        //         anim.SetTrigger("move_up_right");
        //     }
 
        //     if (movement.y == -1 && movement.x == -1)
        //     {
        //         anim.SetTrigger("move_down_left");
        //     }
 
        //     if (movement.y == -1 && movement.x == 1)
        //     {
        //         anim.SetTrigger("move_down_right");
        //     }
        // }
 
        // else
        // {
 
        //     //left/right/up/down
        //     if (movement.x == -1)
        //     {
        //         anim.SetTrigger("move_left");
        //     }
 
        //     if (movement.x == 1)
        //     {
        //         anim.SetTrigger("move_right");
        //     }
 
 
        //     if (movement.y == 1)
        //     {
        //         anim.SetTrigger("move_up");
        //     }
 
 
        //     if (movement.y == -1)
        //     {
        //         anim.SetTrigger("move_down");
        //     }
        // }
 
 
 
    }
 
   
}
 