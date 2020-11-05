using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    public GameObject HintsUI;
    [SerializeField]
    Text text;
    

    public void EnableHintsUI()
    {
        HintsUI.SetActive(true);
    }

    public void DisableHintsUI()
    {
        HintsUI.SetActive(false);
    }

    public void ClickedOnHints()
    {
        EnableHintsUI();
        text.gameObject.SetActive(false);
        FindObjectOfType<PauseButton>().PauseButtonNotInteractable();
        FindObjectOfType<Pausemenu>().DisablePauseMenuUI();
        FindObjectOfType<Hint1Button>().Hint1ButtonInteractable();
        FindObjectOfType<Hint1Button>().Hint1NonTransparent();
        FindObjectOfType<Hint2Button>().Hint2NonTransparent();
        FindObjectOfType<Hint3Button>().Hint3NonTransparent();
        /* if(true)
         {
             FindObjectOfType<Hint2Button>().Hint2ButtonInteractable();
             FindObjectOfType<Hint3Button>().Hint3ButtonInteractable();
         }*/
        if (PlayerPrefs.GetInt("AllHints", 0) == 1)
        {
            
            FindObjectOfType<Hint2Button>().Hint2ButtonInteractable();
            FindObjectOfType<Hint3Button>().Hint3ButtonInteractable();
        }
    }

    public void Hint1()
    {
        Debug.Log("Hint 1 clicked");

        text.gameObject.SetActive(true);
        text.fontSize = 100;
        text.text = "Pinch Me";
        FindObjectOfType<Hint1Button>().Hint1Transparent();
        FindObjectOfType<Hint2Button>().Hint2Transparent();
        FindObjectOfType<Hint3Button>().Hint3Transparent();
    }

    public void Hint2()
    {
        Debug.Log("Hint 2 clicked");
        text.gameObject.SetActive(true);
        text.fontSize = 100;
        text.text = "You need to have a little \"bit\" programming knowledge to \"crack\" this \"one\" ";
        FindObjectOfType<Hint1Button>().Hint1Transparent();
        FindObjectOfType<Hint2Button>().Hint2Transparent();
        FindObjectOfType<Hint3Button>().Hint3Transparent();

    }

    public void Hint3()
    {
        Debug.Log("Hint 3 clicked");
        text.gameObject.SetActive(true);
        text.fontSize = 70;
        text.text = "Text is in the format:\n" +
            "If(condition)\n" +
            "Do This\n" +
            "If a number is placed in the condition it will perform \"Do This\" only if it's a non zero number.";
        FindObjectOfType<Hint1Button>().Hint1Transparent();
        FindObjectOfType<Hint2Button>().Hint2Transparent();
        FindObjectOfType<Hint3Button>().Hint3Transparent();

    }

    public void Back()
    {
        FindObjectOfType<PauseButton>().PauseButtonInteractable();
        DisableHintsUI();
        FindObjectOfType<Pausemenu>().EnablePauseMenuUI();
    }
}
