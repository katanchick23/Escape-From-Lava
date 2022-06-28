using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    private Vector3 _cube;
    public GameObject _explosion;
    public GameObject _fire;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Cube"){
            _cube = other.GetComponent<Transform>().position;
            Instantiate(_fire, new Vector3(_cube.x, _cube.y + 0.1f, _cube.z), Quaternion.identity);
        }
        if(other.tag == "ExplosionTriger"){
            _cube = other.GetComponent<Transform>().position;
            Instantiate(_explosion, new Vector3(_cube.x, _cube.y, _cube.z), Quaternion.identity);
        }
    }
}
