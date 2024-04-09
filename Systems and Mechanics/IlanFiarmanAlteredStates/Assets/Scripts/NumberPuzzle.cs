using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class NumberPuzzle : MonoBehaviour
{
    public GameObject thisMenu;
    public int firstNumber;
    public int secondNumber;
    public int thirdNumber;
    public int fourthNumber;
    public int fifthNumber;
    public int sixthNumber;
    public TextMeshProUGUI num1;
    public TextMeshProUGUI num2;
    public TextMeshProUGUI num3;
    public TextMeshProUGUI num4;
    public TextMeshProUGUI num5;
    public TextMeshProUGUI num6;
    public GameObject actionMenu;
    public bool puzzleComplete = false;

    void Start()
    {
    }

    void Update()
    {
        if (firstNumber == 4 && secondNumber == 6 && thirdNumber == 9 && fourthNumber == 8 && fifthNumber == 2 && sixthNumber == 0)
        {
            actionMenu.GetComponent<ActionMenu>().keyAvailable = true;
            puzzleComplete = true;
        }
        else
        {
            actionMenu.GetComponent<ActionMenu>().keyAvailable = false;
        }
        
    }

    public void closeMenu()
    {
        this.thisMenu.SetActive(false);
    }

    public void firstNumButton()
    {
        firstNumber++;
        if (firstNumber > 9)
        {
            firstNumber = 0;
        }
        num1.text = "0" + firstNumber;
    }

    public void secondNumButton()
    {
        secondNumber++;

        if (secondNumber > 9)
        {
            secondNumber = 0;
        }
        num2.text = "0" + secondNumber;
    }
    public void thirdNumButton()
    {
        thirdNumber++;
        if (thirdNumber > 9)
        {
            thirdNumber = 0;
        }
        num3.text = "0" + thirdNumber;
    }
    public void fourthNumButton()
    {
        fourthNumber++;
        if(fourthNumber > 9)
        {
            fourthNumber = 0;
        }
        num4.text = "0" + fourthNumber;
    }
    public void fifthNumButton()
    {
        fifthNumber++;
        if (fifthNumber > 9)
        {
            fifthNumber = 0;
        }
        num5.text = "0" + fifthNumber;
    }
    public void sixthNumButton()
    {
        sixthNumber++;
        if (sixthNumber > 9)
        {
            sixthNumber = 0;
        }
        num6.text = "0" + sixthNumber;
    }
    
}
