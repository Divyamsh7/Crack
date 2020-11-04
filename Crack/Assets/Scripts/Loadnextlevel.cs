using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadnextlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //nextscene();
        Invoke("workalready", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void workalready()
    {
        nextscene();
    }
    private void nextscene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
