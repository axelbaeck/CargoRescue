using UnityEngine;

public class BandRenderer : MonoBehaviour
{
    public GameObject[] Links;
    LineRenderer Line;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Line = GetComponent<LineRenderer>();
        Line.positionCount = Links.Length;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        for (int i = 0; i < Links.Length; i++)
        {
            Line.SetPosition(i, Links[i].transform.position);
        }
    }
}
