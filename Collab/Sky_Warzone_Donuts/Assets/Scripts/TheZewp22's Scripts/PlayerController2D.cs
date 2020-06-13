using System.Collections;
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
[SerializeField]
float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
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
    }

    


}
