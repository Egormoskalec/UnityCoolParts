using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    private float initialY;

    void Start() {
        initialY = transform.position.y;
    }

    void Update()
    {
        float y = Mathf.PerlinNoise(transform.position.x + Time.time, transform.position.z);
        transform.position = new Vector3(transform.position.x, y + initialY, transform.position.z);

        if (transform.position.y >= 0.5f + initialY)
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
