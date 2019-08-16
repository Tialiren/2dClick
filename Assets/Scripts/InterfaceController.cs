using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceController : MonoBehaviour
{

    public void OnExitClick()
    {
        Application.Quit();
    }

    public void OnRestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Back()
    {
        SceneManager.LoadScene("Main");
    }

}