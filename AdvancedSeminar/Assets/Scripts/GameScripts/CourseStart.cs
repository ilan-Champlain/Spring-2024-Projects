using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseStart : MonoBehaviour
{
    public GameObject TimeKeeper;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        TimeKeeper.GetComponent<Timer>().resetTime();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player)
        {
            TimeKeeper.GetComponent<Timer>().timeStart();
            
        }
        else
        {
            
            TimeKeeper.GetComponent<Timer>().resetTime();
            
        }
        
    }
}
