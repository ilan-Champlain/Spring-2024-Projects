using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActiveSetter : MonoBehaviour
{
    public GameObject Inventory;

    // Update is called once per frame
    void Start()
    {
        Inventory.GetComponent<KeyDetector>().keyObtained = true;
    }
}
