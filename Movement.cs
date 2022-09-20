using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float dirX;
    float dirY;
    public float velocity;
    public Rigidbody2D rb;
    private SpriteRenderer sp; 

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Update(){
        dirX = Input.GetAxisRaw("Horizontal") * velocity;
        dirY = Input.GetAxisRaw("Vertical") * velocity; 
        UpdateDirection();  
    }

    void UpdateDirection(){
            if (dirX > 0){
                sp.flipX = false;
            }
            if (dirX < 0){
                sp.flipX = true;
            }
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(dirX, dirY);
    }

    void NotCarryingCarrots (){
        gameObject.tag = "NotPlayer";
    }
    void CarryingCarrots (){
        gameObject.tag = "Player";
    }
}
