using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cont : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)"))
        {
           // PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("Continue", 1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
