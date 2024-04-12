using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseButtonPressed : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject Using;

    // Update is called once per frame
    void Update()
    {
        if (ButtonMenu.GetComponent<ActionMenu>().usePressed == true)
        {
            Using.SetActive(true);
        }
    }
}
