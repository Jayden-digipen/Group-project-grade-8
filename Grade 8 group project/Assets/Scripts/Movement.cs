using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 9f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rB;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

   

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpingPower);
        }

       



        if (Input.GetButtonUp("Jump") && rB.velocity.y > 0f)
        {
            rB.velocity = new Vector2(rB.velocity.x, rB.velocity.y * 0.5f);
        }

        Flip();
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
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
