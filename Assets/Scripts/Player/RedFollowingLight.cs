using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFollowingLight : MonoBehaviour{
    public Transform PlayerTransform;
    public Transform LavaTransform;
    public Vector3 offset;

    void Update(){
        transform.position = new Vector3(PlayerTransform.position.x + offset.x,LavaTransform.position.y + offset.y,PlayerTransform.position.z + offset.z);
    }
}

