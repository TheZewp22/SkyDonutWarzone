using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
public Transform firePoint;
public GameObject bullet;

public float speed = 5f;


void Update()
{
    if (Input.GetButtonDown("Fire1"))
    {
    Shoot();
    }
}
void Shoot()
{
    GameObject bulletInstantiated = Instantiate(bullet, firePoint.position, firePoint.rotation);
    


}

}
