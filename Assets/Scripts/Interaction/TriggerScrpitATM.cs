using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerScrpitATM : MonoBehaviour
{
    public GameObject ATM;
    public AudioSource Sound;
    
    void Start(){
        Sound.enabled = false;
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag  == "Player"){
            Sound.enabled = true;
            Collider col = ATM.GetComponent<Collider>();
            col.GetComponent<Collider>();
            col.enabled = false;
            transform.DOMove(new Vector3(ATM.transform.position.x, ATM.transform.position.y + 2f, ATM.transform.position.z), 0.7f, false);
            StartCoroutine(ExampleCoroutine());
            IEnumerator ExampleCoroutine(){
                yield return new WaitForSeconds(0.7f);
                transform.DOScale(70, 0.3f);
                yield return new WaitForSeconds(0.301f);
                GameObject.Destroy(ATM);
            }
        }
    }
}
