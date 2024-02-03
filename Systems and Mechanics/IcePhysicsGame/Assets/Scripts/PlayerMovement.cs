using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Code from "bendux" 2D Player Movement In Unity.


    private float horizontal;

    public float speedMultiplier = 1.3f;

    public float speedMilestones = 10f;

    public float speed = 8f;
    public float jumpHeight = 6f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update
    void start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > speedMilestones)
        {
            speedMilestones += speedMilestones;

            speed = speed * speedMultiplier;

        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            Debug.Log("Jumping");
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (Input.GetKeyUp("space") && rb.velocity.y > 0f) {
            rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
