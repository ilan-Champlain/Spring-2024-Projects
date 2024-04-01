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
    public GameObject TV;
 

    // Start is called before the first frame update
    void Start()
    {
        Article1.SetActive(false);
        Instructions.SetActive(false);
        Trigger.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.transform.tag == "Player") 
       {
            Instructions.SetActive(true);
            Action = true;
       }
    }
    private void OnTriggerExit(Collider other)
    {
        Instructions.SetActive(false);
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
                Invoke("ScreenOff", 15);
            }
        }
    }

    void ScreenOff()
    {
        Article1.SetActive(false);
        Action = true;
    }

    
}
