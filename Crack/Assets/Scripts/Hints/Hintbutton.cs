using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hintbutton : MonoBehaviour
{
    public Button hintbutton;

    public void HintButtonInteractable()
    {
        hintbutton.interactable = true;
    }
}
