using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionMenu : MonoBehaviour
{
    public GameObject ThisMenu;
    public bool keyAvailable = false;
    public GameObject key;
    public GameObject finalChamber;
    public GameObject leftChamber;
    public GameObject moveMenu;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveButton()
    {
        moveMenu.SetActive(true);
        this.ThisMenu.SetActive(false);
    }

    public void InteractButton()
    {

    }

    public void TakeButton()
    {
        if (keyAvailable)
        {
            key.SetActive(true);
        }
    }

    public void UseButton()
    {
        if (key && finalChamber)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
