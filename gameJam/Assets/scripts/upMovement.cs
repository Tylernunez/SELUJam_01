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
        if (timer < -18.7)
        {
                Vector3 moveLeft = new Vector3(-1.5F, 0, 0);
                transform.Translate(moveLeft);
        }
        if (timer < -28.7)
        {
            Vector3 moveRight = new Vector3(3.0F, 0, 0);
            transform.Translate(moveRight);
        }
    }
}
