using UnityEngine;

public class SpringControl : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static float RestLength;
    public static float K = 250f;
    public static float Damping = 5f;
    public GameObject UpperV;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearDamping = 1;
        RestLength = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Direction = UpperV.gameObject.transform.position - transform.position;

        float Distance = Direction.magnitude;

        if (Distance < 0.0001f) return;

        float DeltaY = Distance - RestLength;

        if (DeltaY <= 0f) return;

        Vector3 Normal = Direction / Distance;

        Rigidbody upperRb = UpperV.GetComponent<Rigidbody>();

        float SpringForce = DeltaY * K;

        rb.AddForce(Normal * SpringForce);

        if (upperRb != null)
        {
            upperRb.AddForce(-Normal * SpringForce);
        }
    }
}
