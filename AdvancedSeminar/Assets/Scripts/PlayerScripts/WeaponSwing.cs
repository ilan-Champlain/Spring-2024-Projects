using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    public GameObject hammer;

    bool canKill = false;

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
        yield return new WaitForSeconds(1.0f);
        Invoke("killReset", 0.5f);
        hammer.GetComponent<Animator>().Play("New State");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && canKill)
        {
            Destroy(other.gameObject);
            canKill=false;
        }
    }

    public void killReset()
    {
        canKill = false;
    }
}
