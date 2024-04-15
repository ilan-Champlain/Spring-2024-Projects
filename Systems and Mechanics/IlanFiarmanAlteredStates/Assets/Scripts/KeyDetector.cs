using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetector : MonoBehaviour
{
    public GameObject key;
    public bool keyObtained = false;
    public GameObject childKey;
    public GameObject ActionMenu;
    public GameObject puzzleMenu;

    void Start()
    {
        key.SetActive(false);
        childKey.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (keyObtained == true)
        {
            ActionMenu.GetComponent<ActionMenu>().keyAvailable = true;
            if (puzzleMenu.GetComponent<NumberPuzzle>().puzzleComplete == true )
            {
                childKey.SetActive(true);
            }
        }
        
    }
}
