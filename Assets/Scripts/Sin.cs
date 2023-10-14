using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{
    public float Frequency = 1;
    public float Amplitude = 1;
    public float Offset = 1;

    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
    }
    void Update()
    {
        //transform.localPosition = new Vector3(0f, Mathf.Sin(Time.time * 5f) * 0.2f, 0f);
        transform.localScale = _startScale * (Mathf.Sin(Time.time * Frequency * 2 * Mathf.PI) * Amplitude + Offset); 
    }
}
