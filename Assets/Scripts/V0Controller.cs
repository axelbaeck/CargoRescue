using UnityEngine;

public class V0Controller : MonoBehaviour
{
    private Transform Parent;
    private Vector3 Offset;
    private Quaternion OriginalRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Parent = transform.parent;
        Offset = transform.position - Parent.position;
        OriginalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Parent.position + Offset;
        transform.rotation = OriginalRotation;
    }
}
