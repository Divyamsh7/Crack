﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementControl : MonoBehaviour
{
    float dirX;
    int doubleJump = 0;

    public float moveSpeed = 3f, jumpForce = 400f;

    Rigidbody2D rb;    
    public Text textHint1;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();


       // PlayerPrefs.DeleteAll();
    }

    public void TextHint1()
    {
        textHint1.text = "Hint 1 Unlocked";
        StartCoroutine(FadeTextToZeroAlpha(1f, textBox));
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while(i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }

    void Update()
    {
        
        if (PlayerPrefs.GetInt("Cutg", 0) == 1) {
            PlayerPrefs.SetFloat("time", (PlayerPrefs.GetFloat("time", 0) + Time.deltaTime));
        }
        if (PlayerPrefs.GetFloat("time", 0) > 900 && PlayerPrefs.GetFloat("time", 0) < 910)
        {
            PlayerPrefs.SetInt("FirstHint", 1);

            //textBox.text = PlayerPrefs.GetFloat("time", 0).ToString();
        }
           
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
        rb.AddForce(new Vector2(50000, 0), ForceMode2D.Force);
    }




}