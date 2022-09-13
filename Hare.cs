using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hare : MonoBehaviour
{
    public bool carrotOn;
    public AudioSource source;
    public Collider2D collide;

    void Start (){    

        source = GetComponent <AudioSource>();
        collide = GetComponent<Collider2D>();   
        //collide.isTrigger = false;
    }

    void Update (){
        if (carrotOn){
            collide.isTrigger = false;
        }else{
            collide.isTrigger = true;
        }

    }
    void OnCollisionEnter2D(Collision2D other){
        if(carrotOn = true && other.gameObject.tag == "Player"){
            GameObject.Find("GameManager").SendMessage("SubtractCarrot");
            //GameObject.Find("Hare").BroadcastMessage("Dance");
            source.mute = false;
            collide.isTrigger = true;
        }
    }    
    void NoCarrots (){
        carrotOn = false;
    }
    void SomeCarrots (){
        carrotOn = true;
    }
}

