using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private Rigidbody carBody;
    public float speed = 10;
    public Vector3 movement;
    void Start()
    {
        carBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        carBody.AddForce(movement * speed);
    }
}
