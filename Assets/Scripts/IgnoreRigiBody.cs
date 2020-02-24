using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreRigiBody : MonoBehaviour
{

    public Collider2D[] childrenColliders;

    void Start()
    {
        // adding all colliders to an array, but our collider will be added to !
        childrenColliders = GetComponentsInChildren<Collider2D>();


        foreach (Collider2D col in childrenColliders)
        {
            // checking if it is our collider, then skip it, 
            if (col != GetComponent<Collider2D>())
            {
                // if it is not our collider then ignore collision between our collider and childs collider
                Physics2D.IgnoreCollision(col, GetComponent<Collider2D>());
            }
        }
    }
}
