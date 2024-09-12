using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity = 10f;
    public Animator animator;

    Vector2 move;

    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical",move.y);
        animator.SetFloat("velocity", move.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * velocity * Time.fixedDeltaTime);
    }


    
}
