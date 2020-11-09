using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class destroycanvas : MonoBehaviour
{
    public GameObject Canvass;

    public void DisableCanvass()
    {
        Canvass.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("Continue", 0) == 1)
        {
            Debug.Log("I'm here");
            DisableCanvass();
           /* var color = text.color;
            color.a = 0;
            text.color = color;*/
            FindObjectOfType<Loadnextlevel>().EnableTitleUI();
        }
    }
}
