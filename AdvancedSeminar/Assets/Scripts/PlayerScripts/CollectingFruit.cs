using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingFruit : MonoBehaviour
{
    public GameObject Canvas;

    public GameObject spawnFruit;

    private void OnTriggerEnter (Collider other)
    {
        if(other.transform.tag == "Fruit")
        {
            other.gameObject.SetActive(false);
            Canvas.GetComponent<FruitCollection>().fruitGained();
            spawnFruit.GetComponent<SpawnFruit>().fruitSpawn();
        }
    }
}
