using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
Rigidbody2D rb2d;
Transform firePoint;
public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        firePoint = GameObject.FindGameObjectWithTag("firePoint").GetComponent<Transform>();
        rb2d.AddForce(firePoint.right * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
