using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player takes damage!
            other.GetComponent<PlayerController>().health -= damage;
            Debug.Log(other.GetComponent<PlayerController>().health);
        }
    }

    void IncreaseSpeed()
    {
        speed += 0.5f;
    }
}
