using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey("up"))
        {
            print("up arrow key is held down");
            
        }
    }
    public void NextScene()
    {

    }
}
