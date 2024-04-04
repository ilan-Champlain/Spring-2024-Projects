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
        SceneManager.LoadScene("RedEnding");
    }
    public void greenLoad()
    {
        SceneManager.LoadScene("GreenEnding");
    }
    public void blueLoad()
    {
        SceneManager.LoadScene("BlueEnding");
    }
    public void hLoad()
    {
        SceneManager.LoadScene("HumanEnding");
    }
}
