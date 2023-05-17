using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectibleC : MonoBehaviour
{
    public float amplitude = 0.2f; // La amplitud del movimiento
    public float speed = 0.5f; // La velocidad del movimiento
    private float startYPos; // La posición Y inicial del objeto
    public static int total;
    public static event Action OnCollected;
    public AudioClip coinSound;

    void Awake() => total++;

    // Start is called before the first frame update
    void Start()
    {
        startYPos = transform.position.y; // Guardamos la posición Y inicial del objeto
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, Time.time * 100f, 0);
        // Calculamos la posición Y en función del tiempo
        float yPos = startYPos + amplitude * Mathf.Sin(speed * Time.time);

        // Creamos un nuevo vector de posición con la nueva coordenada Y
        Vector3 newPosition = new Vector3(transform.position.x, yPos, transform.position.z);

        // Actualizamos la posición del objeto
        transform.position = newPosition;
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            OnCollected?.Invoke();
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }
    }
}
