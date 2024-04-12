using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingMenu : MonoBehaviour
{
    public GameObject tutorialMenu;
    public GameObject thisMenu;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonTutorial()
    {
        this.gameObject.SetActive(false);
        tutorialMenu.SetActive(true);
    }

    public void beginGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    
}
