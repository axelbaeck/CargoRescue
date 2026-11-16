using System;
using UnityEngine;


public class Waves : MonoBehaviour
{

    public float amplitude = 1f;
    public float frequency = .5f;
    public float wavelenght = 1f;
    const float pi= (float) Math.PI;

    Mesh mesh;
    Vector3[] original;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       mesh = GetComponent<MeshFilter>().mesh;
       original = mesh.vertices;
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3[] v = mesh.vertices;

        for (int i = 0; i < v.Length; i++)
        {
            v[i].y = amplitude * Mathf.Sin(((2*pi)/wavelenght)*original[i].x-(2*pi*frequency*Time.time));
            
        }
        mesh.vertices = v;
        mesh.RecalculateNormals();
    }
}
