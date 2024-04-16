using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class BuildingConstruction : MonoBehaviour
{
    public GameObject Instructions;
    public GameObject Trigger;
    public bool Action = false;
    public GameObject buildHider;
    public GameObject building;
    public AudioSource construction;
    public GameObject player;
    public GameObject parrent;
    public int builtSections = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instructions.SetActive(false);
        Trigger.SetActive(true);
        buildHider.SetActive(false);
        building.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instructions.SetActive(true);
            Action = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        Instructions.SetActive(false);
        Action = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Instructions.SetActive(false);
                Trigger.SetActive(false);
                Action = false;
                buildHider.SetActive(true);
                Invoke("CompleteConstruct", 5);
            }
        }
    }

    void CompleteConstruct()
    {
        player.GetComponent<EndingFinishedCondition>().winScore++;
        building.SetActive(true);
        buildHider.SetActive(false);
    }
}
