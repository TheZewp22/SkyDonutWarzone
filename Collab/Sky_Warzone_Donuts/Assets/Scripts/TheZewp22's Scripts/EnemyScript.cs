using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
//  Pathfinding
public float speed;
public Transform target;
float distance;
[SerializeField]
int health;
[SerializeField]
GameObject gameManager;



void Start()
{
  target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
  gameManager = GameObject.FindGameObjectWithTag("GameController");
}

void Update(){
distance = transform.position.x - target.position.x;
if (health <= 0)
{
gameManager.GetComponent<gameManager>().IncreaseScore();
Destroy(gameObject);
}
//  Move Towards the Player's Target Hitbox
  transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


}

void OnTriggerEnter2D(Collider2D other)
{
if (other.CompareTag("Bullet"))    
{
health--;
}
else if (other.CompareTag("Player") && other.GetComponent<PlayerController2D>().isDashing == true)
{
Debug.Log("Contact: Dashing");
health = 0;
}






}
}
