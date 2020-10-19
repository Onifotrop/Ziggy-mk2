using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightControll : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerControler Player;
    public LayerMask Mask;
    private SpriteRenderer sR;
    public GameObject weight;
    public AudioClip lockSound;
    public GameObject wallBox;
    public AudioSource audioSource;
    void Start()
    {
        sR = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Player.isWeight)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                weight.GetComponent<Rigidbody2D>().gravityScale = 1f;
                wallBox.GetComponent<BoxCollider2D>().enabled = false;
                audioSource.PlayOneShot(lockSound);
            }
        }
    }
}
