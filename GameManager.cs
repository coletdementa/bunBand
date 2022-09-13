using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float carrotCount;
    public float carrotGiven;
    public float totalCarrot = 4;
    public GameObject titleScreen;
    public GameObject player;


    void Start (){
        player = GameObject.Find("Carpincho");
        titleScreen.SetActive (true);
        player.SetActive (false);
    }
    public void StartGame(){
        titleScreen.SetActive (false);
        player.SetActive (true);
        print ("alo");
    }

    void Update (){
        if (carrotGiven >= totalCarrot){
            NoMoreCarrots();
        }

        if (carrotCount == 0){
            NoCount();
        }else{
            SomeCount();
        }

    }
    void AddCarrot(){
        carrotCount ++;
    }

    void SubtractCarrot(){
        carrotCount --;
        carrotGiven ++;
    }

    void NoCount(){
        GameObject.Find("Hare").BroadcastMessage("NoCarrots");
    }

    void SomeCount(){
        GameObject.Find("Hare").BroadcastMessage("SomeCarrots");
    }
    void NoMoreCarrots(){
        GameObject.Find("Boar").SendMessage("Clap");
        GameObject.Find("Hare").BroadcastMessage("Dance");
    }
    void Restart (){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
    }
}
