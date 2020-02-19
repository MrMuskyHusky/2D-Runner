using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public GameObject powerUp;

    public float nextSpawn, spawnRate;
    public float nextSpawnPower, spawnPowerUpRate;
    public int whatToSpawn;
    public bool canSpawn = false;
    public bool canSpawnPower;

    public void Start()
    {
        spawnPowerUpRate = Random.Range(25, 35);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canSpawn = true;
        }
        SpawnObjects();
        PowerUp();
    }

    public void SpawnObjects()
    {
        if (Time.time > nextSpawn && canSpawn == true)
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
            spawnRate = Random.Range(1, 4);
        }
    }

    void PowerUp()
    {
        if(canSpawnPower == true)
        {
            Instantiate(powerUp, this.transform);
            nextSpawnPower = 0;
            spawnPowerUpRate = Random.Range(25, 35);
            canSpawnPower = false;
        }
        if(canSpawnPower == false)
        {
            nextSpawnPower += Time.deltaTime;
            if (nextSpawnPower >= spawnPowerUpRate)
            {
                canSpawnPower = true;
            }
        }
    }
}
