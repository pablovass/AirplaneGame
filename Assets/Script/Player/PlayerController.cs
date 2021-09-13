using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementX;
    private float movementY;
    public float speed=2;
    public float maxSpeed=2;
    public float speedRotation=2;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(movementX, movementY)*speed;
        rb.rotation -= movementX*speedRotation;
        speed = Mathf.Clamp(speed+movementY,1.5f,maxSpeed);
        rb.velocity = transform.up * speed;
    }
}
