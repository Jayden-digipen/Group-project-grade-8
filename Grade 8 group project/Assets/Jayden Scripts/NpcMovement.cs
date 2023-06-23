using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    float moveSpeed = 2f;

    int waypointIndex = 0;
    private bool facingRight = true;
  

    void Start()
    {
        transform.position = waypoints [waypointIndex] .transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
            Flip();
        }

        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            
        }
        
            
        
    }

    private void Flip()
    {
      facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
