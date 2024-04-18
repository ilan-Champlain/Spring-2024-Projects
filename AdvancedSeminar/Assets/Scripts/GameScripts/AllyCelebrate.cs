using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCelebrate : MonoBehaviour
{
    public GameObject player;

    public AudioSource sourceAudio;

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<EndingFinishedCondition>().winScore == 11)
        {
            sourceAudio.Play();
        }
    }
}
