using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancing : MonoBehaviour
{
    private SpriteRenderer sp;
    private Collider2D collide;
    public float number;
    public float seconds;
    public bool dance;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        collide = GetComponent<Collider2D>();
        dance = false;
    }

    void Update()
    {
        if (dance){
            number = number + seconds;
        }
        if (number > 5){
            sp.flipX = true;
        }else{
            sp.flipX = false;
        }
        if (number > 10 || number < 0){
            print ("ok");
            seconds = seconds * -1;
        }
    }
    void Dance (){
        dance = true;
    }

}
