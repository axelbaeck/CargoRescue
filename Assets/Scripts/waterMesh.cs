

using UnityEngine;

public class WaterMesh : MonoBehaviour
{   
    public float width = 100f;
    public float depth = 100f;
    private int  n = 200;



    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vertices = new Vector3[(n+1)*(n+1)];
        float dx = width/n;
        float dz = depth/n;

        int i = 0;
        for (int z = 0; z <= n; z++)
        {
            for (int x = 0; x <=n ;x++)
            {
                vertices[i] = new Vector3(x*dx, 0f, z * dz);
                i++;
            }
        }

        triangles = new int[n*n*6];

        int t = 0;
        for (int z = 0; z<n; z++)
        {
            for(int x = 0; x<n; x++)
            {
                int a = z *(n +1)+x;
                int b = a+1;
                int c = a +n +1;
                int d = c +1;

                int[] two = {a,c,b,b,c,d};
                two.CopyTo(triangles, t);
                t += 6;

            }
        }
        mesh = new Mesh();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        GetComponent<MeshFilter>().mesh = mesh;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
