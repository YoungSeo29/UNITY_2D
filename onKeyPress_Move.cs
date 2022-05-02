using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveSprite : MonoBehaviour
{
    public float speed = 2;  //designate in inspector, distance of 1 second
    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    Rigidbody2D rbody;

    void Start()  //****run initially 
    {
        //set Gravity to 0, so do not rotate
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;    //does not rotate in case of colliding 

    }

    void Update()  //keep running
    {
        vx = 0;
        vy = 0;

        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }

        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }

        if (Input.GetKey("up"))
        {
            vy = speed;
        }

        if (Input.GetKey("down"))
        {
            vy = -speed;
        }
    }

    int count = 0;

    void FixedUpdate()  //******
    {
        if (count == 0)
        {
            this.GetComponent<Rigidbody2D>().Velocity = new Vector2(5, 0);
        }
        if (count == 50)
        {
            this.GetComponent<Rigidbody2D>().Velocity = new Vector2(0, 0);
        }
        count = count + 1;

        /*
       //move
       this.transform.Translate(vx / 50, vy / 50, 0);
       //flip img
       this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        */
    }
}