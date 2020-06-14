using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

int wave = 5;

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
        StartCoroutine(Instantiate ());
        } else {
        Debug.Log(waveCountdown);
        waveCountdown -= Time.deltaTime;
        }

    }





    IEnumerator Instantiate ()
    {
    if (waveCountdown == 0);
    {
    waveCountdown = TimeBetweenWaves;
    for (int i = 0; i < wave; i++)
    {
        yield return new WaitForSeconds (3f);
        rand = Random.Range(0, spawnPoint.Length);
       Transform spawnPointPicked = spawnPoint[rand];
        Instantiate(enemy, spawnPointPicked.position, spawnPointPicked.rotation);
        wave++;
    }
    }
}
}





