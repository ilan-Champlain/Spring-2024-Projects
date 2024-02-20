using Mono.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MixingManager : MonoBehaviour
{
    public GameObject instructions;
    public GameObject mixContainer1;
    public GameObject mixContainer2;
    public GameObject mixContainer3;
    public bool Action = false;
    public Scene redEnd;


    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            instructions.SetActive(true);
            Action = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        instructions.SetActive(false);
        Action = false;
    }

}
