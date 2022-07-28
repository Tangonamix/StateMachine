using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        OldMovement();
    }

    void Movement()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(xAxis, yAxis);

        move.Normalize();
        move *= speed * Time.deltaTime;

        transform.position += (Vector3)move;
    }

    void OldMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 newPosition = transform.position;
            newPosition.y += speed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector2 newPosition = transform.position;
            newPosition.y -= speed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
