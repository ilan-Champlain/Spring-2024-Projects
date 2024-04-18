using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    public GameObject hammer;
    
    public GameObject animationScript;
    public bool canKill = false;
    public AudioSource weapon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        hammer.GetComponent<Animator>().Play("Player Hammer");
        canKill = true;
        weapon.Play();
        yield return new WaitForSeconds(1.0f);
        Invoke("killReset", 0.5f);
        hammer.GetComponent<Animator>().Play("New State");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && canKill)
        {
            //animationScript.GetComponent<AllyAnimationTransition>().enemyIsSlain = true;
            Destroy(other.gameObject, 0.3f);
            canKill =false;
            this.gameObject.GetComponent<EndingFinishedCondition>().winScore++;
        }
    }



    public void killReset()
    {
        canKill = false;
    }
}
