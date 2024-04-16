using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingFinishedCondition : MonoBehaviour
{
    public GameObject endQuestion;
    public int winConditionNumber;
    public int winScore;
    

    // Update is called once per frame
    void Update()
    {
        if (winScore == winConditionNumber)
        {
            endQuestion.SetActive(true);
        }
    }
}
