﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight;
    public bool isJumping = false; // this doesn't need to be public
    private Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) // both conditions can be in the same branch
        {
            _rigidBody2D.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground") // GameObject is a type, gameObject is the property
        {
            isJumping = false;
        }
    }
}