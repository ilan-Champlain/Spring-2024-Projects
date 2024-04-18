using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDies : MonoBehaviour
{
    public GameObject player;
    
    public GameObject animationScript;

    public AudioSource death;

    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (player.GetComponent<WeaponSwing>().canKill == true)
        {
            animationScript.GetComponent<AllyAnimationTransition>().enemyIsSlain = true;
            death.Play();
        }
    }
}
