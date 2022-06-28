using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScrpitATM : MonoBehaviour
{
    public GameObject ATM;
    public Animator animator;
    void OnTriggerEnter(Collider other){
        if(other.tag  == "Player"){
            StartCoroutine(ExampleCoroutine());
            IEnumerator ExampleCoroutine(){
                animator.SetBool("GetATM", true);
                yield return new WaitForSeconds(1.1f);
                GameObject.Destroy(ATM);
            }
        }
    }
}
