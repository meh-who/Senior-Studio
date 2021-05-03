using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTeleport : MonoBehaviour
{
    public Transform player;
    public OVRScreenFade screenFade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(player.position);
            player.position = new Vector3(-26f, 1.2f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(player.position);
            player.position = new Vector3(-27.8f,2.5f,-0.02f);
             StartCoroutine(ChangeScene(5.0f));
        }
    }

    public IEnumerator ChangeScene(float waitT)
    {
        yield return new WaitForSeconds(waitT);
        screenFade.FadeOut();
    }
}
