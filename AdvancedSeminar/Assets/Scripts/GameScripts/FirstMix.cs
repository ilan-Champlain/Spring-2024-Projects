using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMix : MonoBehaviour
{
    Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color=Color.white;
    }

    public void RedColor()
    {
        ren.material.color = Color.red;
    }

    public void BlueColor()
    {
        ren.material.color = Color.blue;
    }

    public void GreenColor()
    {
        ren.material.color = Color.green;
    }

}
