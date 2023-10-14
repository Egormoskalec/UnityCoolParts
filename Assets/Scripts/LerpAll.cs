using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LerpAll : MonoBehaviour
{
    public Transform t1;
    public Transform t3;

    public Material m1;
    public Material m2;
    public Material m3;

    //[Range(0,1)]
    public float value;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = Vector3.LerpUnclamped(t1.position, t3.position, value);
        transform.localScale = Vector3.LerpUnclamped(t1.localScale, t3.localScale, value);
        transform.rotation = Quaternion.LerpUnclamped(t1.rotation, t3.rotation, value);
        m2.color = Color.LerpUnclamped(m1.color, m3.color, value);
    }
}
