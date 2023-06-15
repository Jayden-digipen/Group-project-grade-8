using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private bool isRunning;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check the player's movement state
        float movementSpeed = rb.velocity.magnitude;
        isRunning = (movementSpeed > 0.9f);

        // Update the animator parameter
        animator.SetBool("IsRunning", isRunning);
    }
}
