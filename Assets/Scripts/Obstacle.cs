using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static float speed = 5;
    public float rotateSpeed;
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
        transform.Rotate(Vector2.right * rotateSpeed);
    }

    void IncreaseSpeed()
    {
        speed += 0.5f;
    }
}
