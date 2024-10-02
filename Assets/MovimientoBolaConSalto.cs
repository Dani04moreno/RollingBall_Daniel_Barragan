using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzasalto = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;
        
        rb.MovePosition(rb.position + movement * velocidad * Time.deltaTime);
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * fuerzasalto, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {       
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
