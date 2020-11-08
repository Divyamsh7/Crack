using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadnextlevel : MonoBehaviour
{
    public GameObject TitleUI;
    // Start is called before the first frame update
    void Start()
    {
        //nextscene();
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (PlayerPrefs.GetInt("Continue", 0) == 1)
        {
            //DisableCanvass();
            EnableTitleUI();
           // FindObjectOfType<Loadnextlevel>().EnableTitleUI();
        }*/
    }
    private void workalready()
    {
        nextscene();
    }
    public void EnableTitleUI()
    {
        TitleUI.SetActive(true);
        Invoke("workalready", 2);
    }
    public void nextscene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
