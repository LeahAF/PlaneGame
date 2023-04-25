using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float rotationsSpeed;
    public float prop;


    void Update()
    {
        transform.Rotate(Vector3.forward * rotationsSpeed);
    }
}
