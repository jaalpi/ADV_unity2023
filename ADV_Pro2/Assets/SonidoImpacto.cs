using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoImpacto : MonoBehaviour
{
    public AudioClip impactSound; // El sonido que se reproducirá al colisionar
    private AudioSource audioSource; // El componente de audio del objeto

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(impactSound); // Reproducir el sonido de impacto
        }
    }
}
