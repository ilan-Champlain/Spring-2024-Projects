using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject FirstScene;
    public GameObject Menu;

    void QuitGame()
    {
        Application.Quit();
    }

    void StartGame()
    {
        FirstScene.SetActive(true);
        Menu.SetActive(false);
    }
}
