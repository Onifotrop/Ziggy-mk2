using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard3 : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerControler Player;
    public LayerMask Mask;
    private SpriteRenderer sR;
    public AudioClip keySound;

    public AudioSource audioSource;
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
            Player.isOrange = true;
            sR.enabled = false;
            audioSource.PlayOneShot(keySound);
        }
    }
}
