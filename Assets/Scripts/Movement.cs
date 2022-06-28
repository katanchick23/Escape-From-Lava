using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rotationSpeed;
    private Rigidbody rigidBody;
    public float Speed;
    private Animator animator;
    public Transform groundCheckerTransform;
    public LayerMask notPlayerMask;
    public float JumpForce;
    void Start(){
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 directionVector = new Vector3(h, 0, v);
        if(directionVector.magnitude > 0.1f){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);
        }
        animator.SetFloat("MS", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
        if(Physics.CheckSphere(groundCheckerTransform.position, 0.2f,notPlayerMask)){
            animator.SetBool("IsInAir", false);
        }
        else
        {
            animator.SetBool("IsInAir", true);
        }
    }

    void Jump(){
        if(Physics.CheckSphere(groundCheckerTransform.position, 0.1f,notPlayerMask)){
            rigidBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
    void FixedUpdate(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            rigidBody.AddForce(new Vector3(h,0,0) * Speed);
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)){
            rigidBody.AddForce(new Vector3(0,0,v) * Speed);
        }
    }
}
