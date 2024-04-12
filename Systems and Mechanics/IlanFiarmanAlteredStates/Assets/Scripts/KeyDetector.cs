using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetector : MonoBehaviour
{
    public GameObject key;
    public GameObject ActionMenu;

    // Update is called once per frame
    void Update()
    {
        if (key)
        {
            ActionMenu.GetComponent<ActionMenu>().keyAvailable = true;
            

        }
    }
}
