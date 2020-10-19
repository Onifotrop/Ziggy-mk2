using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{

    
    public GameObject leftBound;
    
    public GameObject rightBound;
    

    private Rigidbody2D thisRigidbody2D;

    public float force;

    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
        thisRigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(new Vector3(force * Time.deltaTime,0,0));
        }

        if (!isRight)
        {
            transform.Translate(new Vector3(-force * Time.deltaTime,0,0));
        }
        if (transform.position.x > rightBound.transform.position.x)
        {
            isRight = false;
        }
        if (transform.position.x < leftBound.transform.position.x)
        {
            isRight = true;
        }
        
    }
}
