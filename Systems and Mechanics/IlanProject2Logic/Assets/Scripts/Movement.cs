using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Sourced code for movement from Firnox. "Create a 2D grid movement player controller script in Unity." https://www.youtube.com/watch?v=yYqJZqYMEa4
    [SerializeField] private bool isRepeadedMovement = false;
    private bool isMoving = false;
    [SerializeField] private float moveDuration = 0.1f;
    [SerializeField] private float gridSize = 1f;
    bool rotatedUp;
    bool rotatedDown;
    bool rotatedLeft;
    bool rotatedRight;
    // Start is called before the first frame update
    void Start()
    {
        rotatedDown = false;
        rotatedUp = false;
        rotatedLeft = false;
        rotatedRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving) { 
        System.Func<KeyCode, bool> inputFunction;
            if (isRepeadedMovement)
            {
                inputFunction = Input.GetKey;
            }
            else
            {
                inputFunction = Input.GetKeyDown;
            }

            if (inputFunction(KeyCode.W))
            {
                StartCoroutine(Move(Vector2.up));
                if (rotatedUp == false)
                {
                    if (rotatedDown == true)
                    {
                        transform.Rotate(0, 0, 180);
                        rotatedDown = false;
                        rotatedUp = true;
                    }
                    else if (rotatedLeft == true)
                    {
                        transform.Rotate(0, 0, -90);
                        rotatedLeft = false;
                        rotatedUp = true;
                    }
                    else if (rotatedRight == true)
                    {
                        transform.Rotate(0, 0, 90);
                        rotatedDown = false;
                        rotatedUp = true;
                    }
                }
            }
            if (inputFunction(KeyCode.S))
            {
                StartCoroutine(Move(Vector2.down));
                if (rotatedDown == false)
                {
                    if (rotatedUp == true)
                    {
                        transform.Rotate(0, 0, 180);
                        rotatedUp = false;
                        rotatedDown = true;
                    }
                    else if (rotatedLeft == true)
                    {
                        transform.Rotate(0, 0, 90);
                        rotatedLeft = false;
                        rotatedDown = true;
                    }
                    else if (rotatedRight == true)
                    {
                        transform.Rotate(0, 0, -90);
                        rotatedRight = false;
                        rotatedDown = true;
                    }
                }
            }
            if (inputFunction(KeyCode.A))
            {
                StartCoroutine(Move(Vector2.left));
                if (rotatedRight == true) 
                { 
                    transform.Rotate(0,0,180);
                    rotatedRight = false;
                    rotatedLeft = true;
                }
                else if (rotatedUp == true)
                {
                    transform.Rotate(0, 0, 90);
                    rotatedUp = false;
                    rotatedLeft = true;
                }
                else if (rotatedDown == true)
                {
                    transform.Rotate(0, 0, -90);
                    rotatedDown = false;
                    rotatedLeft = true;
                }
                
            }
            if (inputFunction(KeyCode.D))
            {
                StartCoroutine(Move(Vector2.right));
                if (rotatedLeft == true)
                {
                    transform.Rotate(0, 0, 180);
                    rotatedLeft = false;
                    rotatedRight = true;
                }
                else if (rotatedUp == true)
                {
                    transform.Rotate(0, 0, 90);
                    rotatedUp = false;
                    rotatedRight = true;
                }
                else if (rotatedDown == true)
                {
                    transform.Rotate(0, 0, -90);
                    rotatedDown = false;
                    rotatedRight = true;
                }
            }
        }

    }

    private IEnumerator Move(Vector2 direction)
    {
        isMoving = true;
        Vector2 startPostion = transform.position;
        Vector2 endPostion = startPostion + (direction * gridSize);

        float elapsedTime = 0;
        while ( elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            float percent = elapsedTime / moveDuration;
            transform.position = Vector2.Lerp(startPostion, endPostion, percent);
            yield return null;
        }
        
        transform.position = endPostion;

        isMoving = false;
    }

}
