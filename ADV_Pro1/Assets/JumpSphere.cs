using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSphere : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        ParticleSystem ps = collision.gameObject.GetComponent<ParticleSystem>(); // get the ParticleSystem component of the collided object, if it has one

        if (ps != null) // if the collided object has a ParticleSystem component
        {
            ps.Play(); // play the ParticleSystem
        }
    }
}
