using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_Jump : MonoBehaviour
{
    public float force = 5.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.right * force);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-Vector3.right * force);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.forward * force);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(-Vector3.forward * force);
        }
    }
}
