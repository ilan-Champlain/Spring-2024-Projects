using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController control;

    public int score;

    private void Awake()
    {
        if (control == null )
        {
            control = this;
            DontDestroyOnLoad( gameObject );
        } else if (control != this)
        {
            Destroy(gameObject);
        }
    }

}
