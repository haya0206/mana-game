using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private float moveInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        float clampedX = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
