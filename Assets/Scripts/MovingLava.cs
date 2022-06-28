using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLava : MonoBehaviour
{
    void Update(){
        transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y + 5, 0.0005f), transform.position.z);
    }

}
