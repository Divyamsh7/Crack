using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovementControl : MonoBehaviour
{
    float dirX;

    public float moveSpeed = 1f, jumpForce = 700f;

    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        dirX = CrossPlatformInputManager.VirtualAxisReference("Horizontal").GetValue;
        Debug.Log("dir value "+dirX);

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
            DoJump();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
    }

    public void DoJump()
    {
        if (rb.velocity.y == 0)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
    }
}
