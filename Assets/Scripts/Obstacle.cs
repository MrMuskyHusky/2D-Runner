using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static float speed = 5;
    public float secondsToDestroy;

    void Start()
    {
        Destroy(this.gameObject, secondsToDestroy);
        IncreaseSpeed();
    }
    void Update()
    {
        Debug.Log(speed+"");
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void IncreaseSpeed()
    {
        speed += 0.5f;
    }
}
