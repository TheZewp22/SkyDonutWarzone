using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

int wave = 10;

//  Enemy Ref
public GameObject enemy;
//  Spawn Point
public Transform[] spawnPoint;
//  Random Number
int rand;
float TimeBetweenWaves = 20f;
float waveCountdown;

    // Start is called before the first frame update
    void Start()
    {
        waveCountdown = TimeBetweenWaves;
    }

    // Update is called once per frame
    void Update()
    {
        if (waveCountdown <= 0f)
        {
        Wave ();
        } else {
        Debug.Log(waveCountdown);
        waveCountdown -= Time.deltaTime;
        }

    }

    void Wave()
    {
    if (waveCountdown == 0);
    {
    waveCountdown = TimeBetweenWaves;
    for (int i = 0; i < wave; i++)
    {
        rand = Random.Range(0, spawnPoint.Length);
       Transform spawnPointPicked = spawnPoint[rand];
        Instantiate(enemy, spawnPointPicked.position, spawnPointPicked.rotation);
        wave++;
    }
        
    } 
    }
}






