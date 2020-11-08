using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject CatUI;
    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCatUI()
    {
        Debug.Log("catui called");
        CatUI.SetActive(true);
        aud.Play();

    }
}
