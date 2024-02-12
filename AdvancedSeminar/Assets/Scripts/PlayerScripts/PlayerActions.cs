using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    public GameObject mixer;
    public GameObject red;
    public GameObject blue;
    public GameObject green;

    public GameObject redFlask;
    public GameObject blueFlask;
    public GameObject greenFlask;

    bool redCollected = false;
    bool blueCollected = false;
    bool greenCollected = false;

    void Update()
    {
        if (redCollected == true)
        {
            redFlask.SetActive(true);
            blueFlask.SetActive(false);
            greenFlask.SetActive(false);
        }
        if (blueCollected == true)
        {
            blueFlask.SetActive(true);
            greenFlask.SetActive(false);
            redFlask.SetActive(false);
        }
        if (greenCollected == true)
        {
            greenFlask.SetActive(true);
            redFlask.SetActive(false);
            blueFlask.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        if (other == red)
        {
            redCollected = true;
            blueCollected = false;
            greenCollected = false;

            Debug.Log("Collided");
        }

        if (other == blue)
        {
            redCollected = false;
            blueCollected = true;
            greenCollected = false;

            Debug.Log("Collided");
        }

        if (other == green)
        {
            Debug.Log("Collided");
            redCollected = false;
            blueCollected = false;
            greenCollected = true;
        }
    }

}
