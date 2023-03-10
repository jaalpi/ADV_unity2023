using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeGamePhysics : MonoBehaviour
{
    public float forceMagnitude = 10f; // the magnitude of the force to apply
    public GameObject myball;		
    private Rigidbody rb; // the Rigidbody3D component of the GameObject
    private Camera mainCamera; // the main Camera

    void Start()
    {
        rb = myball.GetComponent<Rigidbody>(); // get the Rigidbody3D component
        mainCamera = Camera.main; // get the main Camera
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space)) // if the spacebar is being held down
        {
            Vector3 cameraPosition = mainCamera.transform.position; // get the position of the Camera
            Vector3 forceDirection = cameraPosition - transform.position; // calculate the direction from the GameObject to the Camera
            forceDirection.Normalize(); // normalize the direction vector to get a unit vector
            Vector3 force = forceDirection * forceMagnitude; // create a force vector with magnitude forceMagnitude in the direction from the GameObject to the Camera
            rb.AddForce(force); // apply the force to the Rigidbody3D component
        }
    }
}
