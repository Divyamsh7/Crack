using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hint3Button : MonoBehaviour
{
    public Button hint3button;

    public void Hint3ButtonInteractable()
    {
        hint3button.interactable = true;
    }

    public void Hint3NonTransparent()
    {
        var color = hint3button.targetGraphic.color;
        color.a = 225;//higher than 0 otherwise it is invisible
        hint3button.targetGraphic.color = color;
        color = hint3button.GetComponentInChildren<Text>().color;
        color.a = 225;
        hint3button.GetComponentInChildren<Text>().color = color;
    }

    public void Hint3Transparent()
    {
        var color = hint3button.targetGraphic.color;
        color.a = 0;//higher than 0 otherwise it is invisible
        hint3button.targetGraphic.color = color;
        color = hint3button.GetComponentInChildren<Text>().color;
        color.a = 0;
        hint3button.GetComponentInChildren<Text>().color = color;
        


    }
}
