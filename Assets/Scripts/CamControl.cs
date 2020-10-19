using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerObj;
    public bool camMove;
    public float offsetY;
    private Vector3 thisVelocity = Vector3.zero;
    public Transform target;
    public float smoothTime = 0.3f;
    public float maxTime;
    public float currentTime;
    void Start()
    {
        
    }

    // Update is called once per frame
//    void Update()
//    {
//        if (playerObj.transform.position.x >= transform.position.x)
//        {
//            camMove = true;
//        }
//
//        if (camMove)
//        {
//            print("Cam move now");
//            transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y + offsetY,transform.position.z);
//        }
//    }

    void FixedUpdate()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, .5f, -10f));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref thisVelocity, smoothTime);
    }
}
