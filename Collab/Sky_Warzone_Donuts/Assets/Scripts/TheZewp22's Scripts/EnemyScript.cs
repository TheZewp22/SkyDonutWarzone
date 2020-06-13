using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
//  Pathfinding
public float speed;
public Transform target;
float distance;









void Update(){
distance = transform.position.x - target.position.x;
Debug.Log(distance);
//  Move Towards the Player's Target Hitbox
  transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


}


}
