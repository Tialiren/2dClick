using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void OnExitClick()
    {
        Application.Quit();
    }

    public void OnRestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnPlayBalls()
    {
        SceneManager.LoadScene("Ball");
    }
    
    public void OnPlayTower()
    {
        SceneManager.LoadScene("Tower");
    }

    public void OnPlayLabirint()
    {
        SceneManager.LoadScene("Labirint");
    }

    public void OnPlayEditor()
    {
        SceneManager.LoadScene("Editor");
    }

}