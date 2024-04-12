using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomText : MonoBehaviour
{
    public int lineNumber = 1;
    
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject errorText;
    public GameObject errorTrigger;
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
        /*if (errorActive)
        {
            lineNumber = 0;
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(false);
            errorText.SetActive(true);
        }*/
        if (lineNumber >= 4)
        {
            line3.SetActive(false);
            lineNumber = 1;
        }
    }

    public void nextButton()
    {
        lineNumber++;
        if (errorActive == true)
        {
            errorActive = false;
            lineNumber = 1;
            errorTrigger.SetActive(false);
            errorText.SetActive(false);
            errorActive = false;
        }
        
    }
}
