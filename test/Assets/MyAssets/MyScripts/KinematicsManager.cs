using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicsManager : MonoBehaviour
{
    private bool brainOn = true;
    public Transform parent;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        //print(other.name);
        if (other.name == "Camera"){
            Rigidbody CamRb = other.GetComponent<Rigidbody>();
            CamRb.isKinematic = true;
            CamRb.useGravity = false;
            transform.SetParent(parent);
            print("I put the camera on!");
        }

    }

    // private void OnTriggerStay(Collider other)
    // {   
    //     print(other.name);
    //     if (other.name == "Brain"){
    //         brainOn = true;
    //     }else{
    //         brainOn = false;
    //     }
    // }

    // void onTriggerEnter(Collider other){
    //     print(other.name);
    //     if (other.name == "Camera"){
    //         print("cam");
    //         Rigidbody CamRb = other.GetComponent<Rigidbody>();
    //         CamRb.isKinematic = true;
    //         CamRb.useGravity = false;
    //     }
    // }
}
