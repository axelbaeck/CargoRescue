using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class DroneController : MonoBehaviour
{
    float AscendForce = 10f;
    public static Vector3 CurrentPosition;
    float Damping = 4f;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Tilt = Vector3.Dot(transform.up, Vector3.up);
        float Gravity = Physics.gravity.magnitude;

        if (Tilt > 0.1)
        {
            float Thrust = Gravity * rb.mass / Tilt;

            

            if (Keyboard.current.wKey.isPressed)
            {
                Thrust += AscendForce;
            } 
            else if (Keyboard.current.sKey.isPressed)
            {
                Thrust -= AscendForce;
            }
            else
            {
                Thrust -= rb.linearVelocity.y * Damping;
                
                
            }
            if (Keyboard.current.upArrowKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(20, 0, 0);
            } 
            else if (Keyboard.current.downArrowKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(-20, 0, 0);
            } 
            else if (Keyboard.current.leftArrowKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(0, 0, 20);
            } 
            else if (Keyboard.current.rightArrowKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(0, 0, -20);
            } else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            rb.AddForce(transform.up * Thrust);
        } 

        CurrentPosition = transform.position;
        
    }
}
