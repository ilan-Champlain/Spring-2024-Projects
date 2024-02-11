using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void replayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
