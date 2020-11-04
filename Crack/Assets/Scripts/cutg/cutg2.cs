using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutg2 : MonoBehaviour
{
    private SpriteRenderer cutg22;

    private void Awake()
    {
        cutg22 = GetComponent<SpriteRenderer>();

    }
    public void cutg22enable()
    {
        cutg22.enabled = true;
    }

    public void cutg22disable()
    {
        cutg22.enabled = false;
    }
}
