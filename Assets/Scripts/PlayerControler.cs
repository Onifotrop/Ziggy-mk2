using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = Unity.Mathematics.Random;


public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxDistance = 1f;
    public float force = 5f;
    public float jumpForce = 5f;
    public float gravityInAir = 4f;
    public float offsetY;
    public float offsetX;
    public SpriteRenderer thisSprite;
    Rigidbody2D thisRigidbody2D;
    public bool isGrounded;
    public bool canJump;
    public bool canDouble;
    public GameObject doubleBox;
    public LayerMask myLayerMask;
    public Animator anim;
    public float eatNum;
    public float intCount;
    public AudioSource audioSource;

    public AudioClip catOne;

    public AudioClip catTwo;

    public AudioClip catThree;

    public AudioClip catFour;
    //keycard options
    public bool isBlue;

    public bool isBone;

    public bool isOrange;

    public bool isWeight;

    public bool isGreen;

    public bool isGame;
    //RaycastHit2D isHit;
    void Start()
    {
        //thisSprite = GetComponent<SpriteRenderer>();
        thisRigidbody2D = GetComponent<Rigidbody2D>();
        //canJump = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        print(thisRigidbody2D.velocity);
        print(intCount);
        intCount += 1;
        if (intCount >= 100)
        {
            intCount = 0;
        }
        //Movement of player
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isA",true);
            print("A ing");
            thisRigidbody2D.AddForce(Vector2.left * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == false)
            {
                thisSprite.flipX = true;
            }

            
        }
        else
        {
            anim.SetBool("isA",false);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isD",true);
            print("D ing");
            thisRigidbody2D.AddForce(Vector2.right * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == true)
            {
                thisSprite.flipX = false;
            }
        }
        else
        {
            anim.SetBool("isD",false);
        }
        
        //JUMP
        
        if (isGrounded == true)
        {
            print("Grounded");
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                RandomJumpSound();
                canJump = true;
                anim.SetBool("isJump",true);
                print("Spaced");
                
            }
            thisRigidbody2D.gravityScale = 1;
        }
        if (isGrounded == false)
        {
            canJump = false;
            thisRigidbody2D.gravityScale = gravityInAir;
            anim.SetBool("isJump", false);
        }
        
        
        //RayCast for ground detection
        Ray myRay = new Ray(transform.position + new Vector3(-offsetX,offsetY,0),Vector2.down);
        Ray myRay2 = new Ray(transform.position + new Vector3(offsetX,offsetY,0),Vector2.down);
        Ray trigDetect = new Ray(transform.position,Vector2.down);
        
        RaycastHit2D Hit = Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance);
        RaycastHit2D Hit2 = Physics2D.Raycast(myRay2.origin, myRay2.direction, maxDistance);
        Debug.DrawRay(myRay.origin,myRay.direction * maxDistance, Color.red);
        Debug.DrawRay(myRay2.origin,myRay2.direction * maxDistance, Color.red);
        
//        RaycastHit2D HitTwo = Physics2D.Raycast(trigDetect.origin, myRay.direction, maxDistance*100);
//        Debug.DrawRay(myRay.origin,myRay.direction * maxDistance * 50, Color.magenta);
       
        
        
        //if (Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance))
        //if (Hit.collider.gameObject.CompareTag("Ground"))
//        if ((Physics2D.Raycast(trigDetect.origin, myRay.direction, maxDistance))&&HitTwo.collider.gameObject.CompareTag("ForceUp"))
//        {
//            print(HitTwo.collider.gameObject.tag);
//            print("ForceUp");
//            transform.Translate(Vector3.up);
//        }
        
        
        if ((Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance)&& Hit.collider.gameObject.tag == "Ground")||(Physics2D.Raycast(myRay2.origin, myRay2.direction, maxDistance)&& Hit2.collider.gameObject.tag == "Ground"))
        {
            //print("Grounded");
            //thisSprite.color = Color.red;
            isGrounded = true;
        }
        else
        {
            //thisSprite.color = Color.white;
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        if (canJump == true)
        {
            thisRigidbody2D.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
        
    }

    void RandomJumpSound()
    {
        if (intCount > 0 && intCount <= 25)
        {
            audioSource.PlayOneShot(catOne);
        }
        else if (intCount > 25 && intCount <= 50)
        {
            audioSource.PlayOneShot(catTwo);
        }
        else if (intCount > 50 && intCount <= 75)
        {
            audioSource.PlayOneShot(catThree);
        }
        else
        {
            audioSource.PlayOneShot(catFour);
        }
    }    
}
