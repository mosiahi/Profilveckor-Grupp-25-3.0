using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void NewGameBtn(string newGame)
    {
        SceneManager.LoadScene("Intropart");
    }
    public void QuitGameBtn()
    {
        Application.Quit();
    }
}