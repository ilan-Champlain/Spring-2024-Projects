using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject timer;
    public void replayGame()
    {
        SceneManager.LoadScene("Level1");
        timer.GetComponent<GameController>().runTime = 0;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
