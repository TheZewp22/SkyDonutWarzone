using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

public Camera camera;

public float speed = 5;



 
    void FixedUpdate ()
    {
    Vector3 direction = camera.ScreenToWorldPoint(Input.mousePosition);   
    direction.z = 10; 
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed);
    
    }
}
