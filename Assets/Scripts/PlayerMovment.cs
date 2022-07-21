using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    float mx;
    public float movmentSpeed = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
                 mx = Input.GetAxis ("Horizontal");

    }

    private void FixedUpdate()
    {
        Vector2 movment = new Vector2(mx*movmentSpeed, rb.velocity.y);
        rb.velocity = movment;
    }
}
