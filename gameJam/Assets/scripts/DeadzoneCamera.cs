using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadzoneCamera : MonoBehaviour
{
    public GameObject target;

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}