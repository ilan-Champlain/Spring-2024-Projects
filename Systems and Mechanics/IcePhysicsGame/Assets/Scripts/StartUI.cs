using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{

    public GameObject Canvas;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Canvas.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
