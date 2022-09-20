using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancing : MonoBehaviour
{
    private SpriteRenderer sp;
    private Collider2D collide;

    public float danceTempo;
    public float time;
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
            time += Time.deltaTime;
        }
        if (time >= danceTempo){
            sp.flipX = !sp.flipX;
            time = 0;
        }
    }
    void Dance (){
        dance = true;
    }

}
