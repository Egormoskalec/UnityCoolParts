using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDance : MonoBehaviour
{
    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
        DeactivateAction();
    }

    public void ActivateAction()
    {
        anim.enabled = true;
    }

    public void DeactivateAction()
    {
        anim.enabled = false;
    }
}
