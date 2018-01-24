using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Range(1, 10)]
    public float jumpVelocity;
    public float speed;
    public bool inAir = false;
    Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }

       void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
     void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && inAir != true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveHorizontal, 1) * jumpVelocity;
            inAir = true;
            Debug.Log("Jump is being heard");
        }

        
        if (moveHorizontal != 0 && inAir != true)
        {
            Vector2 movement = new Vector2(moveHorizontal, 0f);
            rb.velocity = movement * speed;
        }
    }
}
