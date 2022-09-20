using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == ("Player") || other.gameObject.tag == ("NotPlayer")){
      GameObject.Find("GameManager").SendMessage("AddCarrot");
    }
    if(other.gameObject.tag == ("Player") || other.gameObject.tag == ("NotPlayer")){
      Destroy(gameObject);
    }
  }
}
