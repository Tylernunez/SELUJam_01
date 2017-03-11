﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour {


    public float thrust = 6.0f;
    public Rigidbody rb;
    private float distToGround;
    public float speed = 6.0f;
    public Camera MainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Collider col = this.GetComponent<Collider>();
        distToGround = col.bounds.extents.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("r")) //restart
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded()) //jump
        {
            rb.AddForce(new Vector3(0, 1 * thrust, 0), ForceMode.Impulse);
        }
        if (IsGrounded())
        {
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
            movement = Camera.main.transform.TransformDirection(movement);

            rb.AddForce(movement * speed * Time.deltaTime);
        }
        else
        {
            rb.AddForce(0,-4f,0);
        }
    }
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Element"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Deadzone"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
