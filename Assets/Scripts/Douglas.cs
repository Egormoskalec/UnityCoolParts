using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douglas : MonoBehaviour
{
    public Animator anim;
    public Rigidbody[] allRigidbody;

    void Awake()
    {
        for (int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    public void MakePhysical()
    {
        anim.enabled = false;
        for (int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = false;
        }
    }
}
