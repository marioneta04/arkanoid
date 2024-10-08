using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private float JumpTime = 0.3f;
    [SerializeField] private Transform Caleb;
    [SerializeField] private float crouchHeight = 0.5f;

    private bool isGrounded = false;
    private bool isJumping = false;
    private float jumpTimer;

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isJumping && Input.GetButton("Jump"))
        {
            if (jumpTimer < JumpTime)
            {
                rb.velocity = Vector2.up * jumpForce;

                jumpTimer += Time.deltaTime;
            }
            else
            {
                 isJumping = false;
            }
        }
        
        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            jumpTimer = 0;
        }

        if (isGrounded && Input.GetButton("Fire3"))
        {
            Caleb.localScale = new Vector3(Caleb.localScale.x, crouchHeight, Caleb.localScale.z);

            if (isJumping)
            {
                Caleb.localScale = new Vector3(Caleb.localScale.x, 1f, Caleb.localScale.z);
            }


        }

        if (Input.GetButtonUp("Fire3"))
        {
            Caleb.localScale = new Vector3(Caleb.localScale.x, 1f, Caleb.localScale.z);
        }
       
        
        
    }

}
