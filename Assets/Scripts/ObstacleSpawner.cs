using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{


    [SerializeField] private GameObject obstacle;
    [SerializeField] private float maxTimeBetweenSpawn;
    [SerializeField] private float minTimeBetweenSpawn;
    float spawnTime;
    float timeBetweenSpawn;


    // Update is called once per frame
    void Update()
    {
        timeBetweenSpawn = Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn);
        if (Time.time > spawnTime) 
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn() 
    {
        Instantiate(obstacle, transform.position, transform.rotation);
    }
}
