using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noright : MonoBehaviour
{
    private BoxCollider2D bc;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    public void turnonbcright()
    {
        bc.enabled = true;
    }

    public void turnoffbcright()
    {
        bc.enabled = false;
    }
}
