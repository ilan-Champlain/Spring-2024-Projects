using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwing : MonoBehaviour
{
    public GameObject hammer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Attack());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
            Destroy(other.gameObject);
    }

    IEnumerator Attack()
    {
        hammer.GetComponent<Animator>().Play("Player Hammer");
        yield return new WaitForSeconds(1.0f);
        hammer.GetComponent<Animator>().Play("New State");
    }
}
