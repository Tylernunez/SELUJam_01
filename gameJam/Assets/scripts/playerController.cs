using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour {


    public float thrust = 6.0f;
    public Rigidbody rb;
    private float distToGround;
    public float speed = 6.0f;
    public float acceleration = 6.0f;
    public Camera MainCamera;
    private Vector3 movement;
    private float horizontalMovement;
    private float verticalMovement;
    public MeshRenderer rend;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Collider col = this.GetComponent<Collider>();
        distToGround = col.bounds.extents.y;
        Cursor.lockState = CursorLockMode.Locked;
        rb.maxAngularVelocity = 100;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("r")) //restart
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
        if (IsGrounded())
        {
            horizontalMovement = Input.GetAxis("Horizontal");
            verticalMovement = Input.GetAxis("Vertical");

            movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
            movement = Camera.main.transform.TransformDirection(movement * acceleration);
            if(verticalMovement < 0)
            {
                movement = Camera.main.transform.TransformDirection(movement * acceleration);
            }
            else
            {
                rb.AddForce(movement * speed * acceleration * Time.deltaTime, ForceMode.Impulse);
            }
            

        }
        else
        {

            movement = Camera.main.transform.TransformDirection(movement);
            rb.AddForce(new Vector3(0,-1.0f,0),ForceMode.VelocityChange);
            
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded()) //jump
        {
            Vector3 upwardMovement = new Vector3(0, thrust * speed, 0);
            rb.AddForce(upwardMovement, ForceMode.Acceleration);
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
