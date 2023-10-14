using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    public Rigidbody targetRigidbody;
    public float forcevalue = 200f;
    public ParticleSystem ps;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            targetRigidbody.AddForceAtPosition(transform.up * forcevalue, transform.position);
            ps.Play();
        }
    }
}

