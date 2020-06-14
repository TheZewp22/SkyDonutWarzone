﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
//  Rigidbody2D
Rigidbody2D rb2d;
SpriteRenderer renderer;
float moveInputv;
float moveInputh;
Vector3 mousePos;
float moveSpeed;
[SerializeField]
float moveSpeedValue = 5;
[SerializeField]
float dashSpeed = 20;
[SerializeField]
float dashTime = 5;
public bool isDashing = false;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        moveSpeed = moveSpeedValue;
    }

    // Update is called once per frame
    void Update()
    {
        moveInputv = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        moveInputh = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
    
        
        

        
        

    
    }
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
        rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
        renderer.flipX = false;
        } else if (Input.GetKey("a"))
        {
        rb2d.velocity = new Vector2(-moveSpeed, rb2d.velocity.y);
        renderer.flipX = true;
        } else {
        rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        renderer.flipX = false;
        }

        if (Input.GetKey("w"))
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, moveSpeed);
        } else if (Input.GetKey("s")) {
        rb2d.velocity = new Vector2(rb2d.velocity.x, -moveSpeed);
        } else {
        rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }

        if (Input.GetKeyDown("space"))
        {
        Dash();
        }

    }
    void Dash()
    {
    moveSpeed = dashSpeed;
    Time.timeScale = 0.5f;
    Invoke("ResetDash", dashTime);
    isDashing = true;
    }
    void ResetDash()
    {
    moveSpeed = moveSpeedValue;
    isDashing = false;
    Time.timeScale = 1f;
    }
    


}