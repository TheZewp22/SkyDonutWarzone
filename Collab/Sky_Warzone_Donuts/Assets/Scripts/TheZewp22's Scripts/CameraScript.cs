using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
Rigidbody2D rb2d;
public Camera camera;

public float speed = 5;


    void Start () 
    {
    rb2d = GetComponent<Rigidbody2D>();
    }
 
    void Update ()
    {
    Vector3 direction = camera.ScreenToWorldPoint(Input.mousePosition);   
    direction.z = 10; 
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg * 5;
    Quaternion rotation = Quaternion.AngleAxis(angle + -90, Vector3.forward);
    
 rb2d.rotation = angle;
    }
}
