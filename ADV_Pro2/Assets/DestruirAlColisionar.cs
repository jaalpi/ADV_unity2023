using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlColisionar : MonoBehaviour
{
    public Vector3 spawnPosition; // La posición donde el objeto volverá a aparecer

void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Enemy"))
    {
        gameObject.SetActive(false); // Desactivar el objeto
        Invoke("Respawn", 3f); // Llamar al método Respawn después de 1 segundo
    }
}

void Respawn()
{
    transform.position = spawnPosition; // Mover el objeto a la posición de reaparición
    gameObject.SetActive(true); // Reactivar el objeto
}
}
