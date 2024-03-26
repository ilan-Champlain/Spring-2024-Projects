using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FruitCollection : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int fruitCollected = 0;

    public void fruitGained()
    {
        fruitCollected++;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Fruit Collected: " + fruitCollected;
    }

    
}
