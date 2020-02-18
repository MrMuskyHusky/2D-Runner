using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timerValue, spawnTime;
    public bool canSpawn;
    public GameObject prefabToSpawn;

    public void Start()
    {
        spawnTime = Random.Range(25, 30);
    }
    void TimerFunction()
    {
        if (canSpawn == true)
        {
            Instantiate(prefabToSpawn, this.transform);
            timerValue = 0;
            spawnTime = Random.Range(25, 30);
            canSpawn = false;
        }
        if (canSpawn == false)
        {
            timerValue += Time.deltaTime;
            if (timerValue >= spawnTime)
            {
                canSpawn = true;
            }
        }
    }
    void Update()
    {
        TimerFunction();
    }
}