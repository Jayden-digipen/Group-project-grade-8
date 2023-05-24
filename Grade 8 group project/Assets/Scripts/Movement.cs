using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 9f;
    private float jumpingPower =  1f;
    private bool isFacingRight = true;
    private bool canJump = true;

    [SerializeField] private Rigidbody2D rB;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

   

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
       
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpingPower);
        }


        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Jump();
            
        }

        



        Flip();
    }
    void Jump()
    {
        // Apply upward force to the Rigidbody component
        rB.AddForce(Vector3.up * jumpingPower);

        // Set canJump to false to prevent consecutive jumps
        canJump = true;
    }


    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void FixedUpdate()
    {
        rB.velocity = new Vector2(horizontal * speed, rB.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
