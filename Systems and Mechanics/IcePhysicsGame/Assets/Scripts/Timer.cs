using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject controller;
    public GameObject sceneLoader;

    public TextMeshProUGUI timeText;

    private string currentScene;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = sceneLoader.GetComponent<SceneLoader>().Scene;
        //timeText = TextMeshProUGUI.FindObjectsByType("RunTimeText");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScene != "WinScene")
        {
            controller.GetComponent<GameController>().runTime += Time.deltaTime;
        }
        else if (currentScene == "WinScene")
        {
            controller.GetComponent<GameController>().runTime += 0;
        }

        timeText.text = controller.GetComponent<GameController>().runTime.ToString();
    }
}
