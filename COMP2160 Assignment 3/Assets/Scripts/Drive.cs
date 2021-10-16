using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private Rigidbody carBody;
    public float driveSpeed = 20;
    public float steerSpeed = 10;
    public float driveAccel = 0.5f;
    public float steerAccel = 0.3f;
    public float maxSteerAngle = 1f;
    public float maxRotation = 85;
    private Vector3 movement;
    private Vector3 steering;
    private bool onGround = false;
    private bool isFlipped = false;
    void Start()
    {
        carBody = GetComponent<Rigidbody>();
        carBody.maxAngularVelocity = maxSteerAngle;
    }

    private void FixedUpdate()
    {
        CheckRotation();
        if (onGround && isFlipped == false)
        {
            CarDrive();
        }
    }

    private void CarDrive()
    {
        movement = new Vector3(0, 0, Input.GetAxis("Vertical"));
        steering = new Vector3(0, Input.GetAxis("Horizontal") * Input.GetAxis("Vertical"), 0);
        carBody.AddTorque(steering * steerSpeed * steerAccel);
        carBody.AddRelativeForce(movement * driveSpeed * driveAccel, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            Debug.Log("ON THE GROUND");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
            Debug.Log("OFF THE GROUND");
        }
    }

    private void CheckRotation()
    {
         if (Vector3.Angle(transform.up, Vector3.up) > maxRotation)
        {
            isFlipped = true;
            Debug.Log("CAR IS FLIPPED");
        }
    }
}
