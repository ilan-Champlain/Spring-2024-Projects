using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButtonPressLeft : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject interactable;

    // Update is called once per frame
    void Update()
    {

        if (ButtonMenu.GetComponent<ActionMenu>().interactPressed == true )
        {
            interactable.SetActive(true);
        }
    }
}
