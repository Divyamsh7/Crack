using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutg : MonoBehaviour
{
    private AudioSource aud;
    public float scnddelay = 1f;
    bool once = true;
   
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)"))
        {
            if (once)
            {

                FindObjectOfType<noup>().turnonbcup();
                FindObjectOfType<noright>().turnonbcright();
                FindObjectOfType<noleft>().turnonbcleft();
                FindObjectOfType<DragnMove>().turnoffbcdrag();

                aud.Play();

                PlayerPrefs.SetInt("FirstHint", 1);
                /*//CheckPoint Activated
                FindObjectOfType<checkpointbutton>().CheckPointButtonInteractable();
                FindObjectOfType<checkpointselected>().ChangeColour();*/

                Invoke("cutg1", 3);
                once = false;
            }
          
        }

    }
 
    private void cutg1() {
        FindObjectOfType<cutg1>().cutg11enable();
        Invoke("cutg2", scnddelay);
    }

    private void cutg2()
    {
        FindObjectOfType<cutg1>().cutg11disable();
        FindObjectOfType<cutg2>().cutg22enable();
        
        Invoke("cutg2dis", 1);
    }

    private void cutg2dis()
    {
        FindObjectOfType<cutg2>().cutg22disable();
        FindObjectOfType<noright>().turnoffbcright();
        FindObjectOfType<MovementControl>().Push();
        
    }
}
/*
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
           // Debug.Log("Resume called");
           
        }
        else
        {
             Pause();
            //Debug.Log("Pause called");
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }


    void Pause() {
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
        if(PlayerPrefs.GetInt("AllHints", 0) == 1)
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

 */
