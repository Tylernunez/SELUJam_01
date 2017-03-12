using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float horizontalSpeed = 2.5F;
    public float verticalSpeed = 2.5F;
    public float lockPos = 0;

    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    Vector2 mouseLook;
    Vector2 smoothV;

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);



       
    }
}