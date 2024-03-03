using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject FirstScene;
    public GameObject Menu;

    void Start()
    {
        FirstScene.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        FirstScene.SetActive(true);
        Menu.SetActive(false);
    }
}
