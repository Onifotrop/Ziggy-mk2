using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceController : MonoBehaviour
{
    public bool isTriggered;

    public GameObject Player;
    public PlayerControler playerControl;
    public GameObject topLight;
    public float force;
    
    public Color deactivated;

    public Color activated;
    // Start is called before the first frame update
    void Start()
    {
        topLight.GetComponent<SpriteRenderer>().color = deactivated;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            topLight.GetComponent<SpriteRenderer>().color = activated;
            Player.transform.Translate(0, force * Time.deltaTime, 0);
            playerControl.gravityInAir = 0;
        }
        else
        {
            topLight.GetComponent<SpriteRenderer>().color = deactivated;
            playerControl.gravityInAir = 4;
        }
    }
}
