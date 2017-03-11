using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxis("Vertical");
		float verticalMovement = Input.GetAxis("Horizontal");
		transform.Rotate(horizontalMovement, verticalMovement,0);
	}
}
