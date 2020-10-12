using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    public PlayerControler Player;
    public LayerMask Mask;
    private SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        sR = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player.isBlue = true;
            sR.enabled = false;
        }
    }
}
