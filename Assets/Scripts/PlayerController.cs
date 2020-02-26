using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float jumpHeight;
    public bool isJumping = false; // this doesn't need to be public
    private Rigidbody2D _rigidBody2D;
    public Text tutorialText;
    public GameObject shield;
    public bool isShield;
    public float powerTimer;

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
        isShield = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isJumping) // both conditions can be in the same branch
        {
            _rigidBody2D.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
            isJumping = true;
            tutorialText.gameObject.SetActive(false);
            anim.SetBool("Jump", true);
            anim.SetBool("Running", false);
        }
        Timer();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // If the player touches a gameobject tag as Ground, we want to be able to jump again.
        if (col.gameObject.tag == "Ground") // GameObject is a type, gameObject is the property
        {
            isJumping = false;
            anim.SetBool("Running", true);
            anim.SetBool("Jump", false);
        }
    }

    void Timer()
    {
        // If shield is on
        if(isShield == true)
        {
            // Start decreasing the powerTime float.
            powerTimer -= Time.deltaTime;
            if(powerTimer <= 0f)
            {
                // If the powerTimer hits 0 or goes under 0, we want the gameObject and the bool to be set to false.
                isShield = false;
                shield.SetActive(false);
            }
        }
        if(isShield == false)
        {
            // if isShield is false, reset the timer back to 10;
            powerTimer = 10f;
        }
    }
}