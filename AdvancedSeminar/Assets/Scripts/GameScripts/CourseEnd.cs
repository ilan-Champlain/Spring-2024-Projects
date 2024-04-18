using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseEnd : MonoBehaviour
{
    public GameObject player;
    public GameObject respawn;
    public GameObject TimeKeeper;
    public AudioSource audio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            
            TimeKeeper.GetComponent<Timer>().bestRun();
            player.GetComponent<EndPlayerMovement>().enabled = false;
            player.GetComponent<EndingFinishedCondition>().winScore++;
            Invoke("reRun", 4);
            audio.Play();
            
        }
    }

    void reRun()
    {
        player.GetComponent<EndPlayerMovement>().enabled = true;
        player.transform.position = respawn.transform.position;
        audio.Stop();
    }
}
