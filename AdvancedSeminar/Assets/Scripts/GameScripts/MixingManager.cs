using Mono.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MixingManager : MonoBehaviour
{
    public GameObject instructions;
    public GameObject mixContainer1;
    public GameObject mixContainer2;
    public GameObject mixContainer3;
    public bool Action = false;
    public Scene redEnd;
    private int mixtureRounds;
    private Color container1Color;
    private Color container2Color;
    private Color container3Color;

    private int redCount;
    private int greenCount;
    private int blueCount;
    public GameObject redFlask;
    public GameObject blueFlask;
    public GameObject greenFlask;


    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);
        mixtureRounds = 1;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            instructions.SetActive(true);
            Action = true;
            if (mixtureRounds == 1)
            {
                ChangeColorContainer1();
                
            }
            if (mixtureRounds == 2)
            {
                ChangeColorContainer2();
                
            }
            if(mixtureRounds == 3)
            {
                ChangeColorContainer3();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        instructions.SetActive(false);
        Action = false;
    }

    void ChangeColorContainer1()
    {
        if (redFlask.activeSelf)
        {
            redCount++;
            redFlask.SetActive(false);
        }
        if (blueFlask.activeSelf)
        {
            blueCount++;
            blueFlask.SetActive(false);
        }
        if (greenFlask.activeSelf)
        {
            greenCount++;
            greenFlask.SetActive(false);
        }
        mixtureRounds += 1;
    }

    void ChangeColorContainer2()
    {
        if (redFlask.activeSelf)
        {
            redCount++;
            redFlask.SetActive(false);
        }
        if (blueFlask.activeSelf)
        {
            blueCount++;
            blueFlask.SetActive(false);
        }
        if (greenFlask.activeSelf)
        {
            greenCount++;
            greenFlask.SetActive(false);
        }

        mixtureRounds += 1;
    }

    void ChangeColorContainer3()
    {
        if (redFlask.activeSelf)
        {
            redCount++;
            redFlask.SetActive(false);
        }
        if (blueFlask.activeSelf)
        {
            blueCount++;
            blueFlask.SetActive(false);
        }
        if (greenFlask.activeSelf)
        {
            greenCount++;
            greenFlask.SetActive(false);
        }
    }

}
