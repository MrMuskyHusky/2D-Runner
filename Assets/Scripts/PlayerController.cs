using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float jumpHeight = 300f;
    private Rigidbody2D rigidBody;

    //Variables for grounding system.
    public bool isGrounded;
    public Transform grounder;
    public LayerMask ground;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(grounder.transform.position, ground);

        //Was the key 'W' pushed down?
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            //Add force to the rigid body, none to the x-axis and jumpHeight to the y-axis.
            rigidBody.AddForce(new Vector2(0, jumpHeight));
        }
    }
}