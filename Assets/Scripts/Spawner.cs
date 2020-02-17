using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public GameObject powerUp;

    public float nextSpawn;
    public float spawnRate = 2f;
    public float spawnPowerUpRate = 60f;
    public int whatToSpawn;
    public bool hasStartSpawning = false;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasStartSpawning = true;
            
        }
        SpawnObjects();
        PowerUp();
    }

    public void SpawnObjects()
    {
        if (Time.time > nextSpawn && hasStartSpawning == true)
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
            spawnRate = Random.Range(1, 5);
        }
    }

    public void PowerUp()
    {
        if (nextSpawn > spawnPowerUpRate+0.75f && hasStartSpawning == true)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
            spawnPowerUpRate = Random.Range(20, 35);
        }
    }
}
