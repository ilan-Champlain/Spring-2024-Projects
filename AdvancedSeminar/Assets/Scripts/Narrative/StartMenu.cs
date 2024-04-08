using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject FirstScene;
    public GameObject Menu;
    public GameObject endMenu;

    void Start()
    {
        FirstScene.SetActive(false);
        endMenu.SetActive(false);
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

    public void endLoad()
    {
        endMenu.SetActive(true);
        Menu.SetActive(false);
    }
}
