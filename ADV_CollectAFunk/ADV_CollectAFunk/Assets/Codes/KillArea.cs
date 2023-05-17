using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillArea : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respwan_point;
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respwan_point.transform.position;
    }
}
