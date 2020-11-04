using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class quitt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)"))
        {
            Debug.Log("Quit");
            Application.Quit();
        }

    }
}
