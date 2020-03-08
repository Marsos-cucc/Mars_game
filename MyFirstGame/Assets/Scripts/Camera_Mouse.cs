using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Mouse : MonoBehaviour
{
    float speed = 40.0f;
    public Transform Target;
    float minFov = 15f;
    float maxFov = 90f;
    float sensitivity = 10f;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        if (ThirdPersonCameraController1.mas.Equals(1))
        {
            Camera.main.fieldOfView = 60f;
            ThirdPersonCameraController1.mas = 0;
        }
        else
        {
            Camera.main.fieldOfView = fov;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.position += transform.TransformDirection(new Vector3(-Input.GetAxis("Mouse X") * Time.deltaTime * speed,
                                           0.0f, -Input.GetAxis("Mouse Y") * Time.deltaTime * speed));
        }
    }
}
