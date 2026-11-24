using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    float CameraDistance = 15f;
    float CameraAngle = 20f;
    float Offset = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.xKey.isPressed)
        {
            CameraDistance += 1;
        }
        if (Keyboard.current.zKey.isPressed)
        {
            CameraDistance -= 1;
        }
        Vector3 DronePosition = DroneController.CurrentPosition;
        Vector3 CameraPosition = new Vector3(DronePosition.x, DronePosition.y + CameraDistance * math.sin(CameraAngle * Mathf.Deg2Rad) - Offset, DronePosition.z - CameraDistance * math.cos(CameraAngle * Mathf.Deg2Rad));

        transform.position = CameraPosition;
    }
}
