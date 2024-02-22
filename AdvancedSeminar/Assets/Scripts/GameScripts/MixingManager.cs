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
    public GameObject MixLights;
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
        MixLights.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (Action == true)
            {
                if (mixtureRounds == 1)
                {
                    ChangeColorContainer1();
                    
                }
                else if (mixtureRounds == 2)
                {
                    ChangeColorContainer2();
                    
                }
                else if (mixtureRounds == 3)
                {
                    ChangeColorContainer3();
                    MixLights.SetActive(true);
                }
                
                Action = false;
                instructions.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            instructions.SetActive(true);
            Action = true;
            
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
            mixContainer1.GetComponent<FirstMix>().RedColor();
            redFlask.SetActive(false);
        }
        else if (blueFlask.activeSelf)
        {
            blueCount++;
            mixContainer1.GetComponent<FirstMix>().BlueColor();
            blueFlask.SetActive(false);
        }
        else if (greenFlask.activeSelf)
        {
            greenCount++;
            mixContainer1.GetComponent<FirstMix>().GreenColor();
            greenFlask.SetActive(false);
        }
        mixtureRounds = 2;
    }

    void ChangeColorContainer2()
    {
        if (redFlask.activeSelf)
        {
            redCount++;
            mixContainer2.GetComponent<SecondMix>().RedColor();
            redFlask.SetActive(false);
        }
        else if (blueFlask.activeSelf)
        {
            blueCount++;
            mixContainer2.GetComponent<SecondMix>().BlueColor();
            blueFlask.SetActive(false);
        }
        else if (greenFlask.activeSelf)
        {
            greenCount++;
            mixContainer2.GetComponent<SecondMix>().GreenColor();
            greenFlask.SetActive(false);
        }
        mixtureRounds = 3;
    }

    void ChangeColorContainer3()
    {
        if (redFlask.activeSelf)
        {
            redCount++;
            mixContainer3.GetComponent<ThirdMix>().RedColor();
            redFlask.SetActive(false);
            StartCoroutine(endScene());
        }
        else if (blueFlask.activeSelf)
        {
            blueCount++;
            mixContainer3.GetComponent<ThirdMix>().BlueColor();
            blueFlask.SetActive(false);
            StartCoroutine(endScene());
        }
        else if (greenFlask.activeSelf)
        {
            greenCount++;
            mixContainer3.GetComponent<ThirdMix>().GreenColor();
            greenFlask.SetActive(false);
            StartCoroutine(endScene());
        }

    }

    IEnumerator endScene()
    {
        yield return new WaitForSeconds(5);
        if (redCount > blueCount && redCount > greenCount) 
        {
            SceneManager.LoadScene("RedEnding");
        }

        else if (blueCount > redCount && blueCount > greenCount)
        {
            SceneManager.LoadScene("BlueEnding");
        }

        else if (greenCount > blueCount && greenCount > redCount)
        {
            SceneManager.LoadScene("GreenEnding");
        }

        else
        {
            SceneManager.LoadScene("HumanEnding");
        }
    }

}
