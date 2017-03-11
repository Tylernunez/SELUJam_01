using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


    public float thrust = 6.0f;
    public Rigidbody rb;
    private float distToGround;
    public float speed = 6.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Collider col = this.GetComponent<Collider>();
        distToGround = col.bounds.extents.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector3(0, 1 * thrust, 0), ForceMode.Impulse);
        }
        
            
    }
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(horizontalMovement * speed, 0, verticalMovement * speed));
    }
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

}
