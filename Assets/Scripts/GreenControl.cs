using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenControl : MonoBehaviour
{
    public PlayerControler Player;
    public LayerMask Mask;
    private SpriteRenderer sR;
    public AudioClip keySound;

    public AudioSource audioSource;
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
            Player.isWeight = true;
            sR.enabled = false;
            audioSource.PlayOneShot(keySound);
        }
    }
}
