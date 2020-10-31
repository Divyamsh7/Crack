using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnMove : MonoBehaviour
{
    

    // touch offset allows ball not to shake when it starts moving
    float deltaX, deltaY;
    bool collided = false;

    // reference to Rigidbody2D component
    Rigidbody2D rb;


    // ball movement not allowed if you touches not the ball at the first time
    bool moveAllowed = false;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)") )
        {
            collided = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)"))
        {
            collided = false;
        }

    }


        // Update is called once per frame
        void Update()
    {


        // Initiating touch event
        // if touch event takes place
        if (Input.touchCount > 0)
        {
            //rb.bodyType = RigidbodyType2D.Dynamic;
           // rb.bodyType = RigidbodyType2D.Static;

            // get touch position
            Touch touch = Input.GetTouch(0);


            // obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);


            // get touch to take a deal with
            switch (touch.phase)
            {


                // if you touches the screen
                case TouchPhase.Began:


                    // if you touch the ball
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {


                        // get the offset between position you touches
                        // and the center of the game object
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;


                        // if touch begins within the ball collider
                        // then it is allowed to move
                        
                            moveAllowed = true;
                      
                        // restrict some rigidbody properties so it moves
                        // more  smoothly and correctly
                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;
                        GetComponent<BoxCollider2D>().sharedMaterial = null;
                      //  GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);
                    }
                    break;


                // you move your finger
                case TouchPhase.Moved:
                    // if you touches the ball and movement is allowed then move
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos) && moveAllowed)
                    {
                        if (!collided)
                        {
                            rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                        }
                    }
                        
                   // rb.bodyType = RigidbodyType2D.Static;
                    break;


                // you release your finger
                case TouchPhase.Ended:


                    // restore initial parameters
                    // when touch is ended
                    rb.bodyType = RigidbodyType2D.Static;
                    // GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);
                   
                   // mat.bounciness = 0.75f;
                    //mat.friction = 0.4f;
                   // GetComponent<BoxCollider2D>().sharedMaterial = mat;
                    break;
            }
        }
    }
}

