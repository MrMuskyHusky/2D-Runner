using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Pickup(col);
        }
    }

    void Pickup(Collider2D player)
    {
        PlayerController obj = player.GetComponent<PlayerController>();
        obj.shield.SetActive(true);
        Destroy(gameObject);
    }
}
