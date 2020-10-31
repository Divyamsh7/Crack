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

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
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
        rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
    }

    public void DoJump()
    {
        
        if (doubleJump<=1)
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        doubleJump++;

    }
    
   /* public void jumpBoost() {
        if (hold && jumptime >= 5 && jumptime <= 45)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }
       
        invoke("jumpBoost", 1f);
    }*/

}
/*
 public class LevelComplete : MonoBehaviour
{
    bool possibility = true;
    int left, right = 0, common = 0;

    void Start() {
        left = PlayerPrefs.GetInt("Left", 0);
    }

   
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (possibility)
        {
            if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)") && other.contacts[0].normal.y > 0.5f)
            {
                if (gameObject.tag == "Others")
                {
                    possibility = false;
                    Debug.Log("No chance");
                }

                else if (gameObject.tag == "Left")
                {

                    left++;
                    PlayerPrefs.SetInt("Left", left);
                    Debug.Log("We hit left " + left + " times");
                    if (right > 0)
                    {
                        possibility = false;
                        Debug.Log("No chance");
                    }

                    if (left == 2 && common == 2 && right == 0)
                    {
                        Completed();
                    }
                }
                else if (gameObject.tag == "Right")
                {
                    right++;
                    Debug.Log("We hit right " + right + " times");
                    if (left > 0)
                    {
                        possibility = false;
                        Debug.Log("No chance");
                    }

                    if (right == 2 && common == 2 && left == 0)
                    {
                        Completed();
                    }
                }
                else if (gameObject.tag == "Common")
                {
                    common++;
                    Debug.Log("We hit common " + common + " times");
                    if (left == 2 && common == 2 && right == 0)
                    {
                        Completed();
                    }
                    else if (right == 2 && common == 2 && left == 0)
                    {
                        Completed();
                    }
                }
            }
        }


        void Completed()
        {
            Debug.Log("Level Complete");
        }
    }
} 
 */
