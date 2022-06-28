using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject _player;
    public Movement moveScript;
    public Animator animator;
    public MovingLava lavaScript;
    public GameObject win;

    void Start(){
        win.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            animator = other.GetComponent<Animator>();
            animator.SetBool("AtFinish", true);
            moveScript.enabled = false;
            lavaScript.enabled = false;
            win.SetActive(true);
        }
    }
}
