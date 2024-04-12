using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionMenu : MonoBehaviour
{
    public GameObject ThisMenu;
    public bool keyAvailable = false;
    public bool finalActive = false;
    public bool interactAvailable;
    public bool interactPressed;
    public bool takePressed;
    public bool usePressed;
    public GameObject key;
    public GameObject finalChamber;
    public GameObject rightChamber;
    public GameObject leftChamber;
    public GameObject moveMenu;
    public GameObject RoomText;

    // Update is called once per frame
    void Update()
    {
        if (leftChamber == true)
        {
            interactAvailable = true;
        }
        if (rightChamber == true)
        {
            interactAvailable = true;
        }
        if (finalChamber == true)
        {
            interactAvailable = true;
            finalActive = true;
        }

        else
        {
            interactAvailable = false;
        }
    }

    public void MoveButton()
    {
        moveMenu.SetActive(true);
        this.ThisMenu.SetActive(false);
    }

    public void InteractButton()
    {
        interactPressed = true;
        
    }

    public void TakeButton()
    {
        if (keyAvailable)
        {
            key.SetActive(true);
        }

        takePressed = true;
    }

    public void UseButton()
    {
        if (keyAvailable == true && finalActive == true)
        {
            SceneManager.LoadScene("WinScene");
        }
        else 
        {
            usePressed = true;
        }
        
    }
}
