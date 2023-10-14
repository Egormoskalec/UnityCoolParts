using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinLight : MonoBehaviour
{
    public Light Light;

    void Update()
    {
        float intensity = Mathf.PerlinNoise(Time.time * 5f, 0f) * 10f;
        Light.intensity = intensity;
    }
}
