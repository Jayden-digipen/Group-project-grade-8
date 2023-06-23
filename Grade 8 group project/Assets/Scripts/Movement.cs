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
    float jumpTime = 0.45f;
   
    public float groundCheckRadius = 0.2f;

    [SerializeField] private Rigidbody2D rB;

    private Animator playerAnimation;

    private void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
       
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpingPower);
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
           
  
        }

        playerAnimation.SetFloat("Speed", Mathf.Abs(rB.velocity.x));

        Flip();
    }

    void Jump()
    {

        if (canJump)
        {
        // Apply upward force to the Rigidbody component
        rB.AddForce(Vector3.up * jumpingPower);
            canJump = false;
            StartCoroutine(CanIJumpy());
        }



    }


    IEnumerator CanIJumpy()
    {
       
        yield return new WaitForSeconds(jumpTime);
        canJump=true;
       
    }

    private bool isGrounded;

 


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
