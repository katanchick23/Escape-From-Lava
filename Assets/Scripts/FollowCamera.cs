using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

    public Transform PlayerTransform;
    public Vector3 offset;

    void Update(){
        transform.position = new Vector3(PlayerTransform.position.x + offset.x,PlayerTransform.position.y + offset.y,offset.z);
    }
}