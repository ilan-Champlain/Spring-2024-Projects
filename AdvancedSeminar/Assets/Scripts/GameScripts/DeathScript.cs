using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Weapon")
        {
            Destroy(this);
        }
    }
}
