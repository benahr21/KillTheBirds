using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  
    public GameObject[] objects;                // The prefab to be spawned.
    public float spawnTime = 6f;            // How long between each spawn.
    private Vector3 spawnPosition;
    public static int numOfBirds = 0;
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        

    }

    void Update()
    {
        if (numOfBirds >= 2)
        {
            Application.Quit();
        }
    }

    void Spawn()
    {
        spawnPosition.x = Random.Range(0, 10);
        spawnPosition.y = Random.Range(-4, 4);
        spawnPosition.z = Random.Range(0, 0);

        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
        numOfBirds++;
        
        
    }
}
