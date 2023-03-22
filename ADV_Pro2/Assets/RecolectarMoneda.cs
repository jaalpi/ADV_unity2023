using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarMoneda : MonoBehaviour
{
    public AudioClip sonidoMoneda; // Agrega el archivo de sonido aquí
    private AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Money"))
        {
            fuenteAudio.PlayOneShot(sonidoMoneda); // Reproduce el sonido
            Destroy(collision.gameObject);
        }
    }
}
