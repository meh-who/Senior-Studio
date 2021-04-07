using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;


    public class MaskManager : MonoBehaviour
    {
        public Transform parent;
        private DistanceGrabbable grabbable;
        private Transform trans;
        private Rigidbody rb;
        private bool detached;
        
        // Start is called before the first frame update
        void Start()
        {
            grabbable  = GetComponent<DistanceGrabbable>();
            transform.SetParent(parent);
            rb = GetComponent<Rigidbody>();
            detached = false;
        }

        // Update is called once per frame
        void Update()
        {
            
            bool grabbing = grabbable.isGrabbed;
            if (grabbing == true){
                print(grabbing);
                gameObject.transform.SetParent(null);
                //if (!detached) Detach();           
            }
        }

        void Detach(){
            gameObject.transform.SetParent(null);
            rb.isKinematic = false;
            detached = true;
        }
    }
