using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxDistance = 1f;
    public float force = 5f;
    public float jumpForce = 5f;
    public float gravityInAir = 4f;
    public SpriteRenderer thisSprite;
    Rigidbody2D thisRigidbody2D;
    public bool isGrounded;
    void Start()
    {
        //thisSprite = GetComponent<SpriteRenderer>();
        thisRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement of player
        if (Input.GetKey(KeyCode.A))
        {
            thisRigidbody2D.AddForce(Vector2.left * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == true)
            {
                thisSprite.flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            thisRigidbody2D.AddForce(Vector2.right * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == false)
            {
                thisSprite.flipX = true;
            }
        }
        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
                print("Jumping!");
            }

            thisRigidbody2D.gravityScale = 1;
        }

        if (isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }
        
        
        //RayCast for ground detection
        Ray myRay = new Ray(transform.position,Vector2.down);
        Ray trigDetect = new Ray(transform.position,Vector2.down);
        
        RaycastHit2D Hit = Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance);
        Debug.DrawRay(myRay.origin,myRay.direction * maxDistance, Color.red);
        Debug.DrawRay(myRay.origin,myRay.direction * maxDistance * 50, Color.magenta);
        
        //if (Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance))
        //if (Hit.collider.gameObject.CompareTag("Ground"))
        if ((Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance))&& Hit.collider.gameObject.tag == "Ground")
        {
            print("Grounded");
            thisSprite.color = Color.red;
            isGrounded = true;
        }
        else
        {
            thisSprite.color = Color.white;
            isGrounded = false;
        }
    }
}
