using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 10)]
    public float jumpVelocity;
    public bool inAir = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }
    // Update is called once per frame
    private void FixedUpdate () {
        if (Input.GetButtonDown("Jump") && inAir != true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            inAir = true;
            Debug.Log("Jump is being heard");
        }
	}
}
