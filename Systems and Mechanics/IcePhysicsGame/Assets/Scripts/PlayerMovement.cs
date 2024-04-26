using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Code from "bendux" 2D Player Movement In Unity.


    private float horizontal;

    public float speedMultiplier = 1.5f;

    public float speed = 0f;

    public float jumpHeight = 6f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;

    private bool isRight = true;

    private bool isWallJumping;
    private float wallJumpDirection;
    private float wallJumpingTime = 0.2f;

    private float wallJumpCounter;

    private float wallJumpDuration = 0.4f;

    private Vector2 wallJumpPower = new Vector2(8f, 16f);

    private bool isWallSliding;
    private float slideSpeed = 2f;


    // Update is called once per frame
    void Update()
    {

        speed = Mathf.Clamp(speed, -15f, 15f);

        

        if (Input.GetKey(KeyCode.A))
        {
            speed = speed - 0.3f;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed = speed - 0.3f;
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed = speed + 3;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed = speed + 3;
        }

        if (!isWallJumping)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            Debug.Log("Jumping");
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (Input.GetKeyUp("space") && rb.velocity.y > 0f) {
            rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
        WallSlide();
        WallJump();
        if (!isWallJumping)
        {
            Flip();
        }
    }

    public void Flip()
    {
        if (isRight && horizontal < 0f || !isRight && horizontal > 0f)
        {
            isRight = !isRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }

    private bool IsWalled()
    {
        return Physics2D.OverlapCircle(wallCheck.position, 0.2f, wallLayer);
    }

    private void WallSlide()
    {
        if (IsWalled() && !IsGrounded() && horizontal != 0f)
        {
            isWallSliding = true;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -slideSpeed, float.MaxValue));
        }
        else
        {
            isWallSliding = false;
        }
    }

    private void WallJump()
    {
        if (isWallSliding)
        {
            isWallJumping = false;
            wallJumpDirection = -transform.localScale.x;
            wallJumpCounter = wallJumpingTime;

            CancelInvoke(nameof(StopWallJump));
        }
        else
        {
            wallJumpCounter -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && wallJumpCounter >0f)
        {
            isWallJumping = true;
            rb.velocity = new Vector2(wallJumpDirection * wallJumpPower.x, wallJumpPower.y);
            wallJumpCounter = 0f;
            if (transform.localScale.x != wallJumpDirection)
            {
                isRight = !isRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
            Invoke(nameof(StopWallJump), wallJumpDuration);
        }
    }

    private void StopWallJump()
    {
        isWallJumping = false;
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    
}
