using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaten : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sR;
    public AudioSource audioSource;
    public AudioClip eatClip;
    bool isDone;

    void Start()
    {
        sR = this.GetComponent<SpriteRenderer>();
        isDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && isDone == false)
        {
            sR.enabled = false;
            isDone = true;
            audioSource.PlayOneShot(eatClip);
            
        }
    }
}
