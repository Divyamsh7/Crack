using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MovementControl : MonoBehaviour
{
    float dirX;
    int doubleJump = 0;

    public float moveSpeed = 3f, jumpForce = 400f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {

        dirX = CrossPlatformInputManager.VirtualAxisReference("Horizontal").GetValue;

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            DoJump();
        }

    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        doubleJump = 0;

        if (other.collider.gameObject.tag == "Restart")
        {
            // Debug.Log("Restart");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    public void DoJump()
    {

        if (doubleJump <= 1)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        doubleJump++;

    }

    public void Push()
    {
        rb.AddForce(new Vector2(10000, 0), ForceMode2D.Force);
    }




}