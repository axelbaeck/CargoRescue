using UnityEngine;

public class BandValidation : MonoBehaviour
{
    public GameObject[] Vertices;
    public SpringControl Spring;
    public float Mass = 1f;
    public float Gravity = 9.82f;
    float UpperLinkStretchExp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpperLinkStretchExp = (float)((Vertices.Length - 1) * 1 * 9.82 / SpringControl.K);
    }

    // Update is called once per frame
    void Update()
    {
        /*float SimStretch = Vector3.Distance(Vertices[0].gameObject.transform.position, Vertices[1].gameObject.transform.position) - Spring.RestLength;
        Debug.Log("Expected distance between the first and second vertices: " + UpperLinkStretchExp);
        Debug.Log("Simulated distance between the first and second vertices: " + SimStretch);*/
    }
}
