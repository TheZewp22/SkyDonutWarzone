using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
//  Rigidbody2D
Rigidbody2D rb2d;
float moveInput;
[SerializeField]
float moveSpeed = 5;
[SerializeField]
int horizontalSpeed = 5;
bool isDashing = false;
[SerializeField]
float dashSpeed = 10;
[SerializeField]
float dashTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    
    
        if (Input.GetKey("space"))
        {
        isDashing = true;
        Invoke("ResetDash", dashTime);
        }
    
    
    
    }
    void FixedUpdate()
    {
        if(!isDashing)
        {
        rb2d.velocity = new Vector2(horizontalSpeed, moveInput);
        } else
        {
        rb2d.velocity = new Vector2(dashSpeed, moveInput);
        }
    }
    void ResetDash()
    {
        isDashing = false;
    }

    


}
