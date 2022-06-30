using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressedButton : MonoBehaviour
{   
    public void onClick(){
        SceneManager.LoadScene("Game");
    }
}
