using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAI : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;

    void Update()
    {
        Vector2 directionToPlayer = player.transform.position - transform.position;
        directionToPlayer.Normalize();
        directionToPlayer *= speed * Time.deltaTime;
        transform.position += (Vector3)directionToPlayer;
    }
}
