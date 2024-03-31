using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 move;
    [SerializeField] private float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 1000f;
        Debug.Log($"speed = {moveSpeed}");
    }

    // Update is called once per frame
    void Update()
    {
        //get Input from KB
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Debug.Log("move..");
    }

    private void FixedUpdate()
    {
        //rigidbody movement
        rb2d.AddForce(move * moveSpeed * Time.deltaTime);
        Debug.Log("add force");
    }
}
