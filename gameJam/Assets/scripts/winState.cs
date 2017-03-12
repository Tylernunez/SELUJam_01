using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winState : MonoBehaviour {

    

    private void OnTriggerEnter(Collider other)
    {
    
            roundStart rs = other.GetComponent<roundStart>();
            rs.victory();
            print("sick.");
            Cursor.lockState = CursorLockMode.None;
    }
}
