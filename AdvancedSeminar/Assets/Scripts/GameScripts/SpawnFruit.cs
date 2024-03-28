using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    int spawnChoice;
    public Transform spawnPosition1;
    public Transform spawnPosition2;
    public Transform spawnPosition3;
    public Transform spawnPosition4;
    public GameObject fruit1;
    public GameObject fruit2;
    public GameObject fruit3;
    public GameObject fruit4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fruitSpawn()
    {
        spawnChoice = Random.Range(1,4);
        if (spawnChoice == 1 )
        {
            fruit1.SetActive(true);
        }
        else if (spawnChoice == 2 )
        {
            fruit2.SetActive(true);
        }
        else if(spawnChoice == 3)
        {
            fruit3.SetActive(true);
        }
        else if (spawnChoice == 4)
        {
            fruit4.SetActive(true);
        }
    }
}
