using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 move;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float torque;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        //get Input from KB
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //rotate using AddTorque
        if (Input.GetKeyDown(KeyCode.R))
            rb2d.AddTorque(torque);
    }

    private void FixedUpdate()
    {
        //move with addforce
        rb2d.AddForce(move * moveSpeed * Time.deltaTime);
        
        //move with MovePosition
        //rb2d.MovePosition(rb2d.position + (move * moveSpeed * Time.deltaTime));
        
        //move with velocity
        //rb2d.velocity = move * moveSpeed * Time.deltaTime;
    }
}


