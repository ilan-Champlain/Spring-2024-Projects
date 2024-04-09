using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionMenu : MonoBehaviour
{
    public GameObject ThisMenu;
    public bool keyAvailable = false;
    public bool interactAvailable = false;
    public GameObject key;
    public GameObject finalChamber;
    public GameObject leftChamber;
    public GameObject moveMenu;
    public GameObject RoomText;

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
        if (interactAvailable == false)
        {
            RoomText.GetComponent<RoomText>().errorActive = true;
        }
    }

    public void TakeButton()
    {
        if (keyAvailable)
        {
            key.SetActive(true);
        }

        else if (keyAvailable == false)
        {
            RoomText.GetComponent<RoomText>().errorActive = true;
        }
    }

    public void UseButton()
    {
        if (key && finalChamber)
        {
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            RoomText.GetComponent<RoomText>().errorActive = true;
        }
    }
}
