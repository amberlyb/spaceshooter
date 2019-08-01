﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
     public float speed;

     private Rigidbody rb;

     void Start()
     {
          rb = GetComponent<Rigidbody>();
          rb.velocity = transform.forward * speed;
     }

     void Update ()
     {
          if (Input.GetKeyDown(KeyCode.H))
          {
               rb = GetComponent<Rigidbody>();
               rb.velocity = transform.forward * speed * 2;
          }
     }
}