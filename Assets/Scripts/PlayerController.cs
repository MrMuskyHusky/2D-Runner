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

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
       // shield = GetComponent<GameObject>();
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
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground") // GameObject is a type, gameObject is the property
        {
            isJumping = false;
            anim.SetBool("Running", true);
            anim.SetBool("Jump", false);
        }
    }
}