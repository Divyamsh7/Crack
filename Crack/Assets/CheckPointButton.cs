using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointButton : MonoBehaviour
{
    public Button checkpointbutton;

    public void CheckPointButtonInteractable()
    {
        checkpointbutton.interactable = true;
    }
}
