using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Button pausebutton;

    public void PauseButtonInteractable()
    {
        pausebutton.interactable = true;
    }

    public void PauseButtonNotInteractable()
    {
        pausebutton.interactable = false;
    }
}
