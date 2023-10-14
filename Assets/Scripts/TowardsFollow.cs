using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardsFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 5);
    }
}
