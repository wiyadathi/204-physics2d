using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add2DForceTorque : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float force, torque;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }

        if (Input.GetMouseButtonDown(1))
        {
            rb2d.AddTorque(torque);
        }
    }
}
