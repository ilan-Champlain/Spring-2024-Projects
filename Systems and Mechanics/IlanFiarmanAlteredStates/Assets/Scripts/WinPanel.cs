using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    


    public void replay()
    {
        SceneManager.LoadScene("TitleScene");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
