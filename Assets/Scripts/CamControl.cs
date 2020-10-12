using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerObj;
    public bool camMove;
    public float offsetY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObj.transform.position.x >= transform.position.x)
        {
            camMove = true;
        }

        if (camMove)
        {
            print("Cam move now");
            transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y + offsetY,transform.position.z);
        }
    }
}
