using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;


    public class UnplugOrgan : MonoBehaviour
    {
        public Transform parent;
        private DistanceGrabbable grabbable;
        private Transform trans;
        private Rigidbody rb;
        private bool lastGrabbing;
        
        // Start is called before the first frame update
        void Start()
        {
            grabbable  = GetComponent<DistanceGrabbable>();
            transform.SetParent(parent);
            rb = GetComponent<Rigidbody>();
            lastGrabbing = false;
        }

        // Update is called once per frame
        void Update()
        {
            //if grab the object
            bool grabbing = grabbable.isGrabbed;
            if (grabbing == true){
                //print(grabbing);
                gameObject.transform.SetParent(null);
                //rb.useGravity = false; //optional
                lastGrabbing = grabbing;              
            }
            //if drop the object
            if (lastGrabbing==true && grabbing ==false) {
                rb.isKinematic = false;
                rb.useGravity = true;
            }

        }
    }
