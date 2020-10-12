using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    //public GameObject elevator;
    //public GameObject elevatorTop;
    public bool triggered;
    public bool isUp;

    public bool isDown;

    public float distance;

    public float deltaDis;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        if (isUp)
//        {
//            elevatorTop.GetComponent<SpriteRenderer>().color = new Color(0, 213, 255);
//        }
//        else if (isDown)
//        {
//            elevatorTop.GetComponent<SpriteRenderer>().color = new Color(255, 163, 163);
//        }
        if (triggered)
        {
            if (isUp)
            {
                if (deltaDis < distance)
                {
                    this.transform.Translate(0,speed * Time.deltaTime,0);
                    deltaDis += speed * Time.deltaTime;
                }
            }
            else if (isDown)
            {
                if (deltaDis < distance)
                {
                    this.transform.Translate(0,-speed * Time.deltaTime,0);
                    deltaDis += speed * Time.deltaTime;
                }
            }
        }
        
    }
}
