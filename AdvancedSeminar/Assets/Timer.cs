using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("component")]
    public TextMeshProUGUI timeText;

    [Header("Timer Settings")]
    public float currentTime;
    public float bestTime;
    public bool countDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timeText.text = currentTime.ToString();
    }
}
