using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCommand : MonoBehaviour
{
    public GameObject Instructions;
    public GameObject Trigger;
    public GameObject FlaskContainer;
    public GameObject RightFlask;
    public GameObject Other1Flask;
    public GameObject Other2Flask;
    public bool Action = false;


    //Script inspired by DIGA Hub: https://www.youtube.com/watch?v=1HbH4e0Cg6o
    // Start is called before the first frame update
    void Start()
    {
        Instructions.SetActive(false);
        Trigger.SetActive(true);
        FlaskContainer.SetActive(true);
        RightFlask.SetActive(false);
        Other1Flask.SetActive(false);
        Other2Flask.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Player")
        {
            Instructions.SetActive(false);
            Action = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        Instructions.SetActive(false);
        Action = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (Action == true)
            {
                Instructions.SetActive(false);
                RightFlask.SetActive(true);
                Other1Flask.SetActive(false);
                Other2Flask.SetActive(false);
                Action = false;
            }
        }
    }
}
