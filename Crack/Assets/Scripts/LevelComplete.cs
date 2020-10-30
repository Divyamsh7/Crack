using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    
   
    private void OnCollisionEnter2D(Collision2D other)
    {

        
            if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)") && other.contacts[0].normal.y > 0.5f)
            {
                if (gameObject.tag == "Others")
                {
                FindObjectOfType<GameManager>().HitOthers();
                }

                else if (gameObject.tag == "Left")
                {  
                    FindObjectOfType<GameManager>().HitLeft();   
                }
                else if (gameObject.tag == "Right")
                {
                FindObjectOfType<GameManager>().HitRight();
                }
                else if (gameObject.tag == "Common")
                {
                FindObjectOfType<GameManager>().HitCommon();
                }
            }
    }
}

/*
  bool possibility = true;
    int left, right = 0, common = 0;

    void Awake()
    {
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
                    Debug.Log("We hit left "+left+" times");
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
    

         void Completed() {
            Debug.Log("Level Complete");
        }
    }
 */
