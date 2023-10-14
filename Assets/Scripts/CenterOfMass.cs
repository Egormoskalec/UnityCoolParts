using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public Transform centerOfMassTransform;

    private void Awake()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.Scale(centerOfMassTransform.localPosition, transform.localScale);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.2f);
    }
}

