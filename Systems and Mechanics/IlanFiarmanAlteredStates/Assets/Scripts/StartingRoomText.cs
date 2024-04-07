using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingRoomText : MonoBehaviour
{
    public GameObject textBox;
    public int lineNumber;
    public GameObject centralChamber;
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject errorText;
    public bool errorActive = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextButton()
    {
        
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

    }
}
