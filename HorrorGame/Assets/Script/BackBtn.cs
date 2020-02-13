using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    public GameObject pauseMenuUI; 

    public void Back()
    {
        if (Goback.myGoBackToMain == false)
        {
            SceneManager.LoadScene("Intropart");
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
        
    }
}
