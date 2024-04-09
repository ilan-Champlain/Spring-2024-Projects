using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingRoomText : MonoBehaviour
{
    public int lineNumber = 1;
    public GameObject centralChamber;
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject errorText;
    public bool errorActive = false;

    // Update is called once per frame
    void Update()
    {
        if (lineNumber == 1)
        {
            line1.SetActive(true);
        }
        
        if (lineNumber == 2)
        {
            line1.SetActive(false);
            line2.SetActive(true);
        }
        if (lineNumber == 3)
        {
            line3.SetActive(true);
            line2.SetActive(false);
        }
    }

    public void nextButton()
    {
        lineNumber++;

        if (errorActive)
        {
            errorActive = false;
            errorText.SetActive(false);
        }
    }
    public void moveButton() 
    {
        this.gameObject.SetActive(false);
        centralChamber.SetActive(true);
    }

    public void interactButton()
    {
        errorText.SetActive(true);
        errorActive = true;
    }

    public void takeButton()
    {
        errorText.SetActive(true);
        errorActive = true;
    }

    public void useButton()
    {
        errorText.SetActive(true);
        errorActive = true;
    }
}
