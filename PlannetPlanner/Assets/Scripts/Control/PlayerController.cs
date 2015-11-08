﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public int thrust = 10;
    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



	void Update() {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * thrust);
            Debug.Log("right");

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * thrust);
            Debug.Log("left");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * thrust);
            Debug.Log("down");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * thrust);
            Debug.Log("up");

        }



        if (Input.GetKey(KeyCode.Space))
        {
            rb.isKinematic = false;
        }

        if (Input.GetKey(KeyCode.R))
        {
            resetship(rb);

        }


}

    public void resetship(Rigidbody2D rb)
    {


        rb.isKinematic = true; //stop applying gravity
        rb.position = GetComponent<GravityBody>().startPosition; //move back to start postion
    }

}
