using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public string Scene;

    void OnCollisionEnter2D(Collision2D collide)
    {
        SceneManager.LoadScene (Scene);
        Debug.Log("It tracks");
    }
}
