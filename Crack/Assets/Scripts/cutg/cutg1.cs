using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutg1 : MonoBehaviour
{
    private SpriteRenderer cutg11;

    private void Awake()
    {
        cutg11 = GetComponent<SpriteRenderer>();
        
    }
    public void cutg11enable() {
        cutg11.enabled = true;
    }

    public void cutg11disable()
    {
        cutg11.enabled = false;
    }
}
