using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LineDraw : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private GameObject measureUI;
    private float dist;


    public Transform origin;
    public Transform destination;
    public TMP_Text measureTxt;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);

        measureUI = gameObject.transform.GetChild(0).gameObject;
        measureUI.transform.SetPositionAndRotation(origin.position, gameObject.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);
        dist = Vector3.Distance(origin.position, destination.position);

        measureUI = gameObject.transform.GetChild(0).gameObject;
        measureUI.transform.SetPositionAndRotation(origin.position, gameObject.transform.rotation);
        measureTxt.text = dist.ToString("F2")+ " m";

    }
}
