using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUIMenu : MonoBehaviour
{
    public GameObject startScene;
    public GameObject leftChamber;
    public GameObject rightChamber;
    public GameObject finalChamber;
    public GameObject centralChamber;

    public GameObject thisMenu;
    public GameObject actionUI;

    public void startMove ()
    {
        startScene.SetActive (true);
        leftChamber.SetActive (false);
        rightChamber.SetActive (false);
        centralChamber.SetActive (false);
        finalChamber.SetActive (false);
    }

    public void centralMove ()
    {
        centralChamber.SetActive (true);
        startScene.SetActive (false);
        rightChamber.SetActive (false);
        leftChamber.SetActive(false);
        finalChamber.SetActive(false);
    }

    public void rightMove ()
    {
        rightChamber.SetActive(true);
        leftChamber.SetActive (false);
        finalChamber.SetActive (false);
        centralChamber.SetActive (false);
        startScene.SetActive(false);
    }

    public void finalMove ()
    {
        finalChamber.SetActive(true);
        leftChamber.SetActive(false);
        centralChamber.SetActive(false);
        rightChamber.SetActive(false);
        startScene.SetActive(false);
    }

    public void leftMove ()
    {
        leftChamber.SetActive(true);
        rightChamber.SetActive(false);
        centralChamber.SetActive(false);
        startScene.SetActive(false);
        finalChamber.SetActive(false);
    }

    public void closeMenu()
    {
        thisMenu.SetActive (false);
        actionUI.SetActive (true);
    }
}
