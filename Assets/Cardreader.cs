using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardreader : MonoBehaviour
{
    public LayerMask Mask;

    public PlayerControler Player;

    public Elevator Elevator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Player.isBlue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Elevator.triggered = true;
            }
        }
    }
}
