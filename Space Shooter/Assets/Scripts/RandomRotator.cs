using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    private Rigidbody rb;

    public float tumble;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
    void FixedUpdate()
    {
         if (Input.GetKeyDown(KeyCode.H))
          {
             rb = GetComponent<Rigidbody>();
             rb.angularVelocity = Random.insideUnitSphere * tumble;
          }
    }
}