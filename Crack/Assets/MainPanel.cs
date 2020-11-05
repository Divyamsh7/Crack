using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    public GameObject MainPanelUI;

    public void EnableMainPanelUI()
    {
        MainPanelUI.SetActive(true);
    }

    public void DisableMainPanelUI()
    {
        MainPanelUI.SetActive(false);
    }
}
