using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuScript : MonoBehaviour
{
    
    public GameObject mainMenu;
    public GameObject thisMenu;

    public void back()
    {
        this.thisMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void redLoad()
    {
        SceneManager.LoadScene("ChapterRed");
    }
    public void greenLoad()
    {
        SceneManager.LoadScene("ChapterGreen");
    }
    public void blueLoad()
    {
        SceneManager.LoadScene("ChapterBlue");
    }
    public void hLoad()
    {
        SceneManager.LoadScene("ChapterHuman");
    }
}
