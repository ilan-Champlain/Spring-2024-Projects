using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappling : MonoBehaviour
{
    // Code from Danis https://www.youtube.com/watch?v=Xgh4v1w5DxU
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable;
    public Transform gunTip;
    public Transform gCamera;
    public Transform player;
    public float maxDistance = 100f;
    private SpringJoint joint;
    public AudioSource RopeSound;


    void Awake() {
        lr = GetComponent<LineRenderer>();
    }


    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
            
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }
    }

    void LateUpdate()
    {
        DrawRope();
    }

    void StartGrapple()
    {
        RaycastHit hit;
        if (Physics.Raycast(origin:gCamera.position, direction: gCamera.forward, out hit, maxDistance))
        {
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(a: player.position, b: grapplePoint);

            //Distance grapple will try to keep from grapple point.
            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;

            //Changeable Values for game.
            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

            lr.positionCount = 2;

            RopeSound.Play();
        }
    }

    void DrawRope()
    {
        //if not grabbing doesn't draw rope.
        if (!joint) return;
        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, grapplePoint);
    }

    void StopGrapple()
    {
        RopeSound.Stop();
        lr.positionCount = 0;
        Destroy(joint);
    }
}
