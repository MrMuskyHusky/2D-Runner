using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    public string hitTag = "Player";

    // Make the game run an event when an object/player/enemy enters the trigger zone.
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == hitTag)
        {
            onEnter.Invoke();
        }
    }
}
