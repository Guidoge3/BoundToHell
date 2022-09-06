using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [Header("MoveMent")]

    public float moveSpeed;
    
    public Transform orientation;

    float horizontalInput;
    float veritcalInput;

    Vector3 movementDirection;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        veritcalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate move direction
        movementDirection = orientation.forward * veritcalInput + orientation.right * horizontalInput;

        rb.AddForce(movementDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }
}
