using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MicController : MonoBehaviour
{
    AudioSource speaker;
    static int sampleSize = 512;
    float lowerT = 0.05f;
    float upperT = 0.5f;
    float[] data = new float[sampleSize];

    public float intensity = 0;
    public TMP_Text measureTxt;


    // Start is called before the first frame update
    void Start()
    {
        speaker = gameObject.GetComponent<AudioSource>();
        speaker.clip = Microphone.Start(Microphone.devices[0].ToString(), true, 1, 44100);
        speaker.loop = true;
        while (!(Microphone.GetPosition(null) > 0))
        {
            speaker.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        speaker.GetOutputData(data, 0);
        float sum = 0;
        foreach (float p in data)
        {
            sum += Mathf.Abs(p);
        }
        float avg = sum / sampleSize * 100;
        avg = avg - lowerT;
        if (avg < 0) avg = 0;
        avg = avg / upperT;
        if (avg > 1) avg = 1;
        intensity = avg;

        measureTxt.text = intensity.ToString();
    }
}
