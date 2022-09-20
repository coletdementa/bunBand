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
    public GameObject hares;
    public GameObject boar;


    void Start (){
        player = GameObject.Find("Carpincho");
        titleScreen.SetActive (true);
        player.SetActive (false);
    }
    public void StartGame(){
        titleScreen.SetActive (false);
        player.SetActive (true);
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
        player.SendMessage("NotCarryingCarrots");
        hares.BroadcastMessage("NoCarrots");
    }

    void SomeCount(){
        player.SendMessage("CarryingCarrots");
        hares.BroadcastMessage("SomeCarrots");
    }
    void NoMoreCarrots(){
        boar.SendMessage("Clap");
        hares.BroadcastMessage("Dance");
    }
    void Restart (){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
    }
}
