using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerMovement : MonoBehaviour
{
    //Code for movement and camera control from Dave/GameDevelopment: https://www.youtube.com/watch?v=f473C43s8nE

    [Header("Movement")]
    public float moveSpeed;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    
    public AudioSource stepSounds;
    
    public Transform orientation;
    
    public LayerMask whatIsGround;
    
    float horizontalInput;
    
    float verticalInput;
    
    bool isMoving = false;

    public float jumpForce;

    public float airMultiplier;

    public float jumpCooldown;

    public bool readyToJump;

    public float groundDrag;
    
    [Header("Ground Check")]
    
    bool grounded;
    
    public float playerHeight;

    Vector3 moveDirection;

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        if(grounded)
        {
            rb.drag = groundDrag;
        }
        else if ( !grounded)
        {
            
        }
        {
            rb.drag = 0;
        }

        if (isMoving == true)
        {
            //stepSounds.enabled = true;
        }

        else
        {
            //stepSounds.enabled = false;
        }
        isMovingCheck();
        MyInput();
        SpeedControl();
    }

    private void isMovingCheck()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            isMoving = true;
        }

        else
        {
            isMoving = false;
        }

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }

        else if (!grounded) 
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, rb.velocity.z);

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity= new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
            
        }
        
    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }
}
