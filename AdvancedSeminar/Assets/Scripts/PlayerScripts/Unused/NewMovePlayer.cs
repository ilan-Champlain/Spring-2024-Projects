using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovePlayer : MonoBehaviour
{
    public float MoveSmoothTime;
    public float GravityStrength;
    public float MoveSpeed;
    public float RunSpeed;
    public float jumpStrength;
    public GameObject Orientation;
    public AudioSource StepSounds;

    private CharacterController controller;
    private Vector3 CurrentMoveVelocity;
    private Vector3 MoveDampVelocity;

    private Vector3 CurrentForceVelocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerInput = new Vector3()
        {
            x = Input.GetAxisRaw("HorizontalWrapMode"),
            y = 0f,
            z = Input.GetAxisRaw("Vertical")
        };

        if(PlayerInput.magnitude > 1f)
        {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput);
        float CurrentSpeed = Input.GetKey(KeyCode.LeftShift) ? RunSpeed : MoveSpeed;
        controller.Move(CurrentMoveVelocity * Time.deltaTime);

        CurrentMoveVelocity = Vector3.SmoothDamp(
            CurrentMoveVelocity, MoveVector * CurrentSpeed,
            ref MoveDampVelocity,
            MoveSmoothTime);

        Ray groundCheckRay = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(groundCheckRay, 1.1f))
        {
            CurrentForceVelocity.y = -2f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                CurrentForceVelocity.y = jumpStrength;
            }
        }
        else
        {
            CurrentForceVelocity.y -= GravityStrength * Time.deltaTime;
        }
    }
}
