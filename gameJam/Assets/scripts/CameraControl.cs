using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float horizontalSpeed = 2.5F;
    public float verticalSpeed = 2.5F;
    public float lockPos = 0;

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, lockPos);
    }
}