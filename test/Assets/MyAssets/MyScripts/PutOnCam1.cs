using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;


public class PutOnCam1 : MonoBehaviour
{
    private bool brainOn = true;
    public Transform parent;
    public TMP_Text compTxt;
    public Transform platform;
    
    public GameObject bLight;

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
            Transform CamTrans = other.GetComponent<Transform>();
            CamRb.isKinematic = true;
            CamRb.useGravity = false;
            CamTrans.SetParent(parent);
            compTxt.text = "welcome.";

            print("I put the camera on!");

            StartCoroutine(ChangeScene(6.0f,5.0f));
        }

    }

    public IEnumerator ChangeScene(float waitT, float transT)
    {
        yield return new WaitForSeconds(2.5f);
        Debug.Log("next level");
        platform.DOMoveY(-7.0f,transT)
            .SetEase(Ease.InOutSine);

        yield return new WaitForSeconds(waitT);
        compTxt.text = "next,throw out your lung to control the lighting";

        yield return new WaitForSeconds(3.0f);
        bLight.SetActive(true);
        

    }


}
