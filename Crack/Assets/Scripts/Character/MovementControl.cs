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
        //PlayerPrefs.DeleteAll();
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
        if (other.collider.gameObject.name == "BrickOthers (139)") {
            // Debug.Log("We hit checkpoint brick");
            //PlayerPrefs.SetInt("AllHints", 1);
            //Debug.Log("ALl hints is " + PlayerPrefs.GetInt("AllHints", 0));
            if (PlayerPrefs.GetInt("AllHints", 0) == 1 && PlayerPrefs.GetInt("Restart", 1) == 1)
            {
                PlayerPrefs.SetInt("ReachCheckPointBrick", PlayerPrefs.GetInt("ReachCheckPointBrick", 0) + 1);
                PlayerPrefs.SetInt("Restart", 0);
                //  Debug.Log("We hit it "+ PlayerPrefs.GetInt("ReachCheckPointBrick", 0) +" times");
            }
            Debug.Log("ReachCheckPointBrick " + PlayerPrefs.GetInt("ReachCheckPointBrick", 0));

            // Debug.Log("We hit checkpoint brick");
        } 
       // Debug.Log(other.collider.gameObject.name);

        if (other.collider.gameObject.tag == "Restart")
        {
                PlayerPrefs.SetInt("Restart", 1);
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