using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    Vector3 movementInput;
    public float speed;
    // Start is called before the first frame update
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        movementInput = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movementInput.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementInput.z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementInput.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movementInput.x = -1;
        }
    }
    protected void FixedUpdate()
    {
        Mover(movementInput);
    }
    void Mover(Vector3 direction)
    {
        rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
    }
}
