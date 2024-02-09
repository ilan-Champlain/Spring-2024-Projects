using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    

    private void Update()
    {
        scoreUI.text = GameController.control.score.ToString();
    }

}
