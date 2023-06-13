using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 9f;
    private float jumpingPower =  1f;
    private bool isFacingRight = true;
    private bool canJump = true;
    public float jumpForce = 5f;
    float jumpTime = 0.5f;
   
    public float groundCheckRadius = 0.2f;

    [SerializeField] private Rigidbody2D rB;

   

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
       
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpingPower);
        }

        Debug.Log(rB.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            StartCoroutine(CanIJumpy());
  
        }
        



        Flip();
    }

    void Jump()
    {

        if (canJump)
        {
        // Apply upward force to the Rigidbody component
        rB.AddForce(Vector3.up * jumpingPower);
            canJump = false;
        }



    }


    IEnumerator CanIJumpy()
    {
        canJump = false;
        yield return new WaitForSeconds(jumpTime);
        canJump = true;
    }

    private bool isGrounded;

 


    private void FixedUpdate()
    {
        rB.velocity = new Vector2(horizontal * speed, rB.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal > 0f || !isFacingRight && horizontal < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
