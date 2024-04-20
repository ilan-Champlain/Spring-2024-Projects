using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public GameObject Line1;
    public GameObject Image1;
    public GameObject Line2;
    public GameObject Image2;
    public GameObject Line3;
    public GameObject Image3;
    public GameObject Line4;
    public GameObject Image4;
    public GameObject Line5;
    public GameObject Image5;
    public GameObject Line6;
    public GameObject Line7;
    public GameObject Line8;
    public GameObject Line9;
    GameObject currentLine;
    public string sceneName;

    int dialogueLine = 1;

    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            dialogueLine += 1;
        }
        if (dialogueLine == 1)
        {
            Line1.SetActive(true);
        }
        else if (dialogueLine == 2)
        {
            Line2.SetActive(true);
            Line1.SetActive(false);
            Image1.SetActive(false);
            Image2.SetActive(true);
        }
        else if (dialogueLine == 3)
        {
            Line3.SetActive(true);
            Line2.SetActive(false);

        }
        else if (dialogueLine == 4)
        {
            Line4.SetActive(true);
            Line3.SetActive(false);
            Image2.SetActive(false);
            Image3.SetActive(true);
        }
        else if (dialogueLine == 5)
        {
            Line5.SetActive(true);
            Line4.SetActive(false);
            Image3.SetActive(false);
            Image4.SetActive(true);
        }
        else if (dialogueLine == 6)
        {
            Line6.SetActive(true);
            Line5.SetActive(false);
        }
        else if (dialogueLine == 7)
        {
            Line7.SetActive(true);
            Line6.SetActive(false);
        }
        else if (dialogueLine == 8)
        {
            Line8.SetActive(true);
            Line7.SetActive(false);
        }
        else if (dialogueLine == 9)
        {
            Line9.SetActive(true);
            Line8.SetActive(false);
            Image4.SetActive(false);
            Image5.SetActive(true);
        }
        else if (dialogueLine == 10)
        {
           dialogueLine = 0;
           SceneManager.LoadScene(sceneName);
        }
        
    }

    public void Skip()
    {
        SceneManager.LoadScene(sceneName);
    }
}
