using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTrigger : MonoBehaviour
{
    public GameObject ChamberName;
    public GameObject errorTrigger;

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            ChamberName.GetComponent<RoomText>().errorActive = true;
        }
        else
        {
            ChamberName.GetComponent<RoomText>().errorActive = false;
        }
    }
}
