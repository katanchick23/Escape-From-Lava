using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanelScript : MonoBehaviour
{
    public Canvas startPanel;
    public Light lGame;
    public Movement moveScript;
    public MovingLava lavaScript;

    void Start()
    {
        startPanel.enabled = true;
        lGame.GetComponent<Light>().intensity = 0.3f;
        moveScript.enabled = false;
        lavaScript.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            lGame.GetComponent<Light>().intensity = 1f;
            startPanel.enabled = false;
            moveScript.enabled = true;
            lavaScript.enabled = true;
        }
    }
}
