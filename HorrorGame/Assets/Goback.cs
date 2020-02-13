using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goback : MonoBehaviour
{
    static public bool myGoBackToMain = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Intropart"))
        {
            myGoBackToMain = false;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            myGoBackToMain = true;
        }
    }
}
