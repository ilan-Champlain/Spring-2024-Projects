using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("component")]
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI bTimeText;

    [Header("Timer Settings")]
    public float currentTime;
    public float bestTime;
    public bool countDown;
    public bool startTime = false;


    // Start is called before the first frame update
    void Start()
    {
        
        bestTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime == true)
        {
            currentTime += Time.deltaTime;
            
        }
        
        timeText.text = currentTime.ToString();
        bTimeText.text = currentTime.ToString();
    }

    public void timeStart()
    {
        startTime = true;
        Debug.Log(startTime);
    }

    public void resetTime()
    {
        startTime = false;
        Debug.Log(startTime);
        if (currentTime < bestTime)
        {
            bestTime = currentTime;
        }

    }
}
