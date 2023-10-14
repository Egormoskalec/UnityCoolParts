using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdateTime : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update ----------" + Time.time);
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate ----------" + Time.time);
    }
}
