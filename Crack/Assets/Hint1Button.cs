using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint1Button : MonoBehaviour
{
    public Button hint1button;

    public void Hint1ButtonInteractable()
    {
        hint1button.interactable = true;
    }

    public void Hint1NonTransparent()
    {
        var color = hint1button.targetGraphic.color;
        color.a = 225;//higher than 0 otherwise it is invisible
        hint1button.targetGraphic.color = color;
        color = hint1button.GetComponentInChildren<Text>().color;
        color.a = 225;
        hint1button.GetComponentInChildren<Text>().color = color;
    }

    public void Hint1Transparent()
    {
        var color = hint1button.targetGraphic.color;
        color.a = 0;//higher than 0 otherwise it is invisible
        hint1button.targetGraphic.color = color;
        color = hint1button.GetComponentInChildren<Text>().color;
        color.a = 0;
        hint1button.GetComponentInChildren<Text>().color = color;


    }
    

}
