using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hint2Button : MonoBehaviour
{
    public Button hint2button;

    public void Hint2ButtonInteractable()
    {
        hint2button.interactable = true;
    }

    public void Hint2NonTransparent()
    {
        var color = hint2button.targetGraphic.color;
        color.a = 225;//higher than 0 otherwise it is invisible
        hint2button.targetGraphic.color = color;
        color = hint2button.GetComponentInChildren<Text>().color;
        color.a = 225;
        hint2button.GetComponentInChildren<Text>().color = color;
    }

    public void Hint2Transparent()
    {
        var color = hint2button.targetGraphic.color;
        color.a = 0;//higher than 0 otherwise it is invisible
        hint2button.targetGraphic.color = color;
        color = hint2button.GetComponentInChildren<Text>().color;
        color.a = 0;
        hint2button.GetComponentInChildren<Text>().color = color;


    }
}
