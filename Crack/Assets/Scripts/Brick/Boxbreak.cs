﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxbreak : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer sr;
    private BoxCollider2D bc;

    private void Awake() {
        particle = GetComponentInChildren<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other) {

       // Debug.Log("we hit");
        if (other.collider.gameObject.GetComponent<Rigidbody2D>().ToString().Equals("Character (UnityEngine.Rigidbody2D)") && other.contacts[0].normal.y > 0.5f)
        {
            StartCoroutine(Break());
           
        }
        
    }
    private IEnumerator Break() {
        particle.Play();
        sr.enabled = false;
        bc.enabled = false;
        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
