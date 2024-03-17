using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVSwitch : MonoBehaviour
{
    public GameObject Instructions;
    public GameObject Trigger;
    public GameObject player;
    public bool Action = false;
    public GameObject Article1;
 

    // Start is called before the first frame update
    void Start()
    {
        Article1.SetActive(false);
        Instructions.SetActive(false);
        Trigger.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Instructions.SetActive(false);
                
                Action = false;
                Article1.SetActive(true);
                Invoke("ScreenOff", 10);
            }
        }
    }

    void ScreenOff()
    {
        Article1.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player") 
        {
            Debug.Log("Colliding");
            Instructions.SetActive(true);
            Action = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Instructions.SetActive(false);
        Action = false;
    }
}
