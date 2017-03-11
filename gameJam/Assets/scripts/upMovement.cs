using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upMovement : MonoBehaviour {
    float timer = 5.0F;
    // Update is called once per frame
    void Update () {
        timer -= Time.deltaTime;
        if(timer > 0.0)
        {
            Vector3 moveUp = new Vector3(0, 2.0F, 0);
            transform.Translate(moveUp);
        }
      
    }
}
