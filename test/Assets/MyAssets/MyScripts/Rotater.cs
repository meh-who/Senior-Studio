using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class Rotater : MonoBehaviour
{

    [SerializeField] private float _duration = 1.5f;
    [SerializeField] private Ease _ease = Ease.Linear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateBridge(){
        var curRotZ = transform.rotation.z;
        transform.DORotate(new Vector3(0, curRotZ + 30, 0), _duration)
        .SetRelative()
        .SetEase(_ease);
    }
}
