using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Spaceship : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.maxAngularVelocity = Mathf.Infinity;
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * speed;
        rb.AddRelativeForce(0f, 0f, forwardForce);
        rb.AddRelativeTorque(0f, sideForce, 0f);
    }
}


