using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// public SpriteRenderer spriteRenderer;
public class Run : MonoBehaviour {
    Animator anim;
    public float speed = 5f;
    public int state = 0;
    private Vector2 movement;
    private Rigidbody2D rb;

    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    private SpriteRenderer spriteRenderer;
 
    // Use this for initialization
    void Start () {
        //anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
 
            //left/right/up/down
            if (movement.x == -1)
            {
                ChangeObjectSprite(leftSprite);
            }
 
            if (movement.x == 1)
            {
               ChangeObjectSprite(rightSprite);
            }
 
 
            if (movement.y == 1)
            {
                ChangeObjectSprite(upSprite);
            }
 
 
            if (movement.y == -1)
            {
                ChangeObjectSprite(downSprite);
            }
 
    }

    void ChangeObjectSprite(Sprite newSprite)
    {
        if (spriteRenderer != null && newSprite != null)
        {
            // Устанавливаем новый спрайт для SpriteRenderer
            spriteRenderer.sprite = newSprite;
        }
        else
        {
            Debug.LogError("SpriteRenderer или новый спрайт не установлены.");
        }
    }
 
    public void ChangePosition()
    {
        transform.position = new Vector2(-5.11f, 3.16f);
    }
   
}
 