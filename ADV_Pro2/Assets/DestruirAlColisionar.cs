using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlColisionar : MonoBehaviour
{
    public GameObject respawnPoint; // El objeto donde quieres que respawn el GameObject A
    public float respawnTime = 5f; // El tiempo en segundos antes de respawnear el GameObject A

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Comprobar si el GameObject A ha colisionado con el GameObject B
        {
            Destroy(gameObject); // Destruir el GameObject A
            StartCoroutine(Respawn()); // Iniciar la corrutina para respawnear el GameObject A
        }
    }

    IEnumerator Respawn()
    {
        Debug.Log("Iniciando corrutina de respawn");
        yield return new WaitForSeconds(respawnTime); // Esperar el tiempo especificado antes de respawnear
        GameObject newGameObject = Instantiate(gameObject, respawnPoint.transform.position, Quaternion.identity); // Crear un nuevo GameObject A en la respawnPoint y asignarlo a una variable
        newGameObject.transform.position = respawnPoint.transform.position; // Establecer la posición del nuevo GameObject A
        newGameObject.transform.rotation = Quaternion.identity; // Establecer la rotación del nuevo GameObject A
        newGameObject.SetActive(true); // Activar el nuevo GameObject A
        Debug.Log("Se ha instanciado un nuevo GameObject A en la posición: " + respawnPoint.transform.position);
    }
}
