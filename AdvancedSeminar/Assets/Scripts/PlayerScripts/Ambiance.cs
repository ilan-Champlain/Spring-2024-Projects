using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambiance : MonoBehaviour
{
    public AudioSource ambiance;
    // Start is called before the first frame update
    void Start()
    {
        ambiance.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
