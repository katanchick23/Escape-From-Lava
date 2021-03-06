using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Animator animator;
    public Movement moveScript;
    public GameObject Lose;
    public MovingLava lavaScript;
    public StartPanelScript PanelScript;

    void Start(){
        animator.SetBool("Dead", false);
        Lose.SetActive(false);
    }
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            moveScript.enabled = false;
            PanelScript.enabled = false;
            StartCoroutine(ExampleCoroutine());
            IEnumerator ExampleCoroutine()
            {   
                animator.SetBool("Dead", true);
                yield return new WaitForSeconds(2);
                lavaScript.enabled = false;
                Lose.SetActive(true);
            }
        }
    }
}