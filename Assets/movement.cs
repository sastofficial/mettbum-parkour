using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(4, rb.velocity.y);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-4, rb.velocity.y);
        }
    }
}
