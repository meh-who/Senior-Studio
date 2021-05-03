using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class Rotater : MonoBehaviour
{

    [SerializeField] private float _duration = 1.5f;
     [SerializeField] private float _degree = 45f;
    [SerializeField] private Ease _ease = Ease.Linear;
    private Tween _rotateTween;
    float curRotZ;
    float newZ = 45;
    // Start is called before the first frame update
    void Start()
    {
        curRotZ = transform.eulerAngles.y;
        Debug.Log( curRotZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateBridge(){
        
        // if (_rotateTween == null)
	    // {
            Debug.Log(newZ);
		    _rotateTween = transform.DORotate(new Vector3(0, newZ, 0), _duration);
            newZ += 45;
	    // }
	    // else
	    // {
		//     _rotateTween.Kill();
		//     _rotateTween = null;
	    // }
    }
}
