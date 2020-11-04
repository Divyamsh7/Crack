using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noup : MonoBehaviour
{
    private BoxCollider2D bc;

    private void Awake()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    public void turnonbcup() {
        bc.enabled = true;
    }
}
