using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreTaker : MonoBehaviour
{

    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.control.score++;
        Debug.Log(GameController.control.score);
    }

}
