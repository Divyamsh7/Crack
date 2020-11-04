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
        Time.timeScale = 1f;
        GameIsPaused = false;

    }


    void Pause()
    {
        pauseMenuUI.SetActive(true);

        //checking whether first hint condition is met
        if (PlayerPrefs.GetInt("FirstHint", 0) == 1 || PlayerPrefs.GetInt("AllHints", 0) == 1)
        {
            //FindObjectOfType<checkpointbutton>().CheckPointButtonInteractable();
            //FindObjectOfType<checkpointselected>().ChangeColour();
            FindObjectOfType<Hintbutton>().HintButtonInteractable();
            FindObjectOfType<HinttextActive>().ChangeColour();

        }

        Time.timeScale = 0f;
        GameIsPaused = true;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void Hints()
    {
        if (PlayerPrefs.GetInt("AllHints", 0) == 1)
            Debug.Log("All Hint Activated");
        else
            Debug.Log("First Hint Activated");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }
}
