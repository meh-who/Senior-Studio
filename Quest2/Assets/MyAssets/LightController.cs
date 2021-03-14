using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject breath;
    private bool on = false;
    private float intensity = 0f;
    private Light sun;
    // Start is called before the first frame update
    void Start()
    {
        sun = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        intensity = breath.GetComponent<MicController>().intensity;


        if (intensity > 0)
        {
            sun.intensity += 0.01f;
        }
        if (intensity == 0)
        {
            sun.intensity -= 0.01f;
        }
    }
}
