using UnityEngine;
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

     void FixedUpdate ()
     {
          if (Input.GetKey(KeyCode.H))
          {
               rb = GetComponent<Rigidbody>();
               rb.velocity = transform.forward * speed * 3;
          }
     }
}