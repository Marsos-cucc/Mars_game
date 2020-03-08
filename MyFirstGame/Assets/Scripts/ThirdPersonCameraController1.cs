using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController1 : MonoBehaviour
{

    public float RotationSpeed = 2;
    public float PosSpeed = 5.0f;
    public Transform Target, Camera;
    float mouseX, mouseY;
    public float eltelt;
    public float mehet;
    public float nem;
    public static float mas;
    public Camera cam;

    void Start()
    {
        mehet = 1;
        nem = 0;
        mas = 0;
    }

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            Target.Translate(new Vector3(PosSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Target.Translate(new Vector3(-PosSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Target.Translate(new Vector3(0, 0, -PosSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Target.Translate(new Vector3(0, 0, PosSpeed * Time.deltaTime));
        }
        if (Input.GetMouseButtonDown(2))
        {
            if (eltelt < 0.15)
            {
                nem = 1;
                eltelt = 0;
                Target.position = new Vector3(0, 3, 0);
                Camera.Rotate(0, 0, 0);
                mouseX = 0;
                transform.Rotate(0, 0, 0);
                mas = 1;
            }
        }
        if (Input.GetKey(KeyCode.Mouse2))
        {
            if (nem.Equals(0))
            {
                mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
                Target.rotation = Quaternion.Euler(0, -mouseX, 0);
            }
            else
            {
                nem = 0;
            }
            eltelt = 0;
        }
        if (mehet.Equals(1))
        {
            eltelt += Time.deltaTime;
        }


    }
}
