using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }


    public void gamepaused()
    {

        if (GameIsPaused)
        {
            Resume();
             Debug.Log("Resume called");

        }
        else
        {
            Pause();
            Debug.Log("Pause called");
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
       // FindObjectOfType<MainPanel>().EnableMainPanelUI();
        Time.timeScale = 1f;
        GameIsPaused = false;

    }


    void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        // FindObjectOfType<MainPanel>().EnableMainPanelUI();

        //checking whether hint condition is met
        /*if (true) {
            
        }*/
       // Debug.Log("First Hint " + PlayerPrefs.GetInt("FirstHint", 0));
       // Debug.Log("AllHints " + PlayerPrefs.GetInt("AllHints", 0));
        if (PlayerPrefs.GetInt("FirstHint", 0) == 1 || PlayerPrefs.GetInt("AllHints", 0) == 1)
        {
            
            //FindObjectOfType<checkpointbutton>().CheckPointButtonInteractable();
            //FindObjectOfType<checkpointselected>().ChangeColour();
            FindObjectOfType<Hintbutton>().HintButtonInteractable();
            FindObjectOfType<HinttextActive>().ChangeColour();
        }
       // Debug.Log("ReachCheckPointBrick " + PlayerPrefs.GetInt("ReachCheckPointBrick", 0));
        //checking whether checkpoint condition is met
        if (PlayerPrefs.GetInt("ReachCheckPointBrick", 0) >= 3)
        {
           // Debug.Log("Condition satisfied");
            //FindObjectOfType<checkpointbutton>().CheckPointButtonInteractable();
            //FindObjectOfType<checkpointselected>().ChangeColour();
            FindObjectOfType<CheckPointButton>().CheckPointButtonInteractable();
            FindObjectOfType<CheckPointTextActive>().ChangeColour();
        }

        Time.timeScale = 0f;
        GameIsPaused = true;
       // FindObjectOfType<MainPanel>().DisableMainPanelUI();

    }

    public void Restart()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }


    public void Hints()
    {
      //  Debug.Log("Hints Called");
        FindObjectOfType<Hints>().ClickedOnHints();
       /* if (PlayerPrefs.GetInt("AllHints", 0) == 1)
            Debug.Log("All Hint Activated");
        else
            Debug.Log("First Hint Activated");*/
    }

    public void EnablePauseMenuUI()
    {
        pauseMenuUI.SetActive(true);
    }

    public void DisablePauseMenuUI()
    {
        pauseMenuUI.SetActive(false);
    }

    public void CheckPoint()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("CheckPoint");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }
}
