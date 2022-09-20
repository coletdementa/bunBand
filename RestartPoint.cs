using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RestartPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == ("NotPlayer")){
            GameObject.Find("GameManager").SendMessage("Restart");
        }
    }
}
