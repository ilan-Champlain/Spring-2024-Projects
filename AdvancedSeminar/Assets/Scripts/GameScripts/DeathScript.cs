using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Weapon")
        {
            Object.Destroy(enemy);
        }
    }
}
