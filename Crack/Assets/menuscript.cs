using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.GetInt("ReachCheckPointBrick", 0) >= 3)
        {
            // Debug.Log("Condition satisfied");
            //FindObjectOfType<checkpointbutton>().CheckPointButtonInteractable();
            //FindObjectOfType<checkpointselected>().ChangeColour();
            Debug.Log("Interactable");
            FindObjectOfType<CheckPointButton>().CheckPointButtonInteractable();
            FindObjectOfType<checkpointtext2>().ChangeColour();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CheckPoint()
    {
        Debug.Log("clicked on checkpoint");
        SceneManager.LoadScene("CheckPoint");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }
}
