using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noleft : MonoBehaviour
{
    private BoxCollider2D bc;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    public void turnonbcleft()
    {
        bc.enabled = true;
    }
}
