using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeReader : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask Mask;

    public PlayerControler Player;

    public Elevator Elevator;
    public AudioClip lockSound;

    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Player.isOrange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Elevator.triggered = true;
                audioSource.PlayOneShot(lockSound);
            }
        }
    }
}
