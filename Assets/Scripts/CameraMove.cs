using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 0.4f;
    [SerializeField]
    private float moveSpeed = 2f;

    private Vector3 mousePreveousePos;
    private float rotationX;
    private float rotationY;

    void Update()
    {
        Move();
        Rotate();
    }


    void Move()
    {
        float shiftMult = 1f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            shiftMult = 3f;
        }

        float right = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        float up = 0;
        if (Input.GetKey(KeyCode.E))
        {
            up = 1f;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            up = -1f;
        }

        Vector3 offset = new Vector3(right, up, forward) * moveSpeed * shiftMult * Time.unscaledDeltaTime;
        transform.Translate(offset);
    }

    void Rotate()
    {

        Vector3 mouseDelta;

        if (Input.GetMouseButtonDown(1))
        {
            mousePreveousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            mouseDelta = Input.mousePosition - mousePreveousePos;
            mousePreveousePos = Input.mousePosition;

            rotationX -= mouseDelta.y * mouseSensitivity;
            rotationY += mouseDelta.x * mouseSensitivity;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0f);
        }
    }

}

