using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public float Speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        var inputDirection = Input.GetAxis("Horizontal");
        var newPosition = transform.position;

        if (inputDirection > 0)
        {
            newPosition.x += Speed * Time.deltaTime;
        }
        else if (inputDirection < 0)
        {
            newPosition.x -= Speed * Time.deltaTime;
        }

        if (!(newPosition.x < minX || newPosition.x > maxX))
        {
            transform.position = newPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bomb"))
        {
            Time.timeScale = 0f;
        }
    }
}
