using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObstaculo : MonoBehaviour
{
    public Transform pointA; // Punto A
    public Transform pointB; // Punto B
    public float speed = 1f; // Velocidad de movimiento

    private bool movingToB = true; // ¿Se está moviendo hacia el punto B?

    void Update()
    {
        if (movingToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
            if (transform.position == pointB.position)
                movingToB = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
            if (transform.position == pointA.position)
                movingToB = true;
        }
    }
}
