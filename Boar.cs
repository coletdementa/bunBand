using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boar : MonoBehaviour
{
    public AudioSource source;
    public Collider2D collide;

    void Start()
    {
        source = GetComponent <AudioSource> ();
        collide = GetComponent <Collider2D> ();
        collide.isTrigger = false;
    }

    void Update(){
    }

    void Clap(){
        source.mute = false;
        collide.isTrigger = true;
        GameObject.Find("Boar").SendMessage("Dance");
    }
}
