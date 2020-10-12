using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanControl : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerControler Player;
    public LayerMask Mask;
    private SpriteRenderer sR;
    public GameObject Evan;
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
            Player.isBone = true;
            sR.enabled = false;
            Evan.GetComponent<AreaEffector2D>().enabled = false;
            Evan.GetComponent<SpriteRenderer>().enabled = false;
            Evan.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
