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
    public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fruitSpawn()
    {
        spawnChoice = Random.Range(1,4);
        if (spawnChoice == 1 )
        {
            Instantiate(fruit, spawnPosition1.transform);
        }
        else if (spawnChoice == 2 )
        {
            Instantiate (fruit, spawnPosition2.transform);
        }
        else if(spawnChoice == 3)
        {
            Instantiate (fruit, spawnPosition3.transform);
        }
        else if (spawnChoice == 4)
        {
            Instantiate (fruit, spawnPosition4.transform);
        }
    }
}
