using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseEnd : MonoBehaviour
{
    public GameObject player;
    public GameObject respawn;
    public GameObject TimeKeeper;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            TimeKeeper.GetComponent<Timer>().resetTime();
            player.GetComponent<EndPlayerMovement>().enabled = false;
            Invoke("reRun", 4);
            
        }
    }

    void reRun()
    {
        player.GetComponent<EndPlayerMovement>().enabled = true;
        player.transform.position = respawn.transform.position;
    }
}
