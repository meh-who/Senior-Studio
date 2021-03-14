using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandTrackinGrabber : OVRGrabber
{
    private OVRHand hand;
    public float pinchThreshold = .7f;
    protected override void Start()
    {
        base.Start();
        hand  = GetComponent<OVRHand>();

    }

    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }
    void CheckIndexPinch()
    {
        float pinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength >pinchThreshold;
        //Debug.Log("grabbed");
        if(!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
            Debug.Log("grabbed");
        }   
        else if(m_grabbedObj && !isPinching) 
            GrabEnd();

    }

}
