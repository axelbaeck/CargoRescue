using UnityEngine;

public class RandomPlacer : MonoBehaviour
{

    public GameObject Box10;
    public GameObject Box50;
    public GameObject Box100;

    public int count10 = 7;
    public int count50 = 5;
    public int count100 = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Place();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Place()
    {
        for (int i = 0; i<= count10; i++)
        {
            float rndX = Random.Range(10,991);
            float rndZ = Random.Range(10,991);
            Vector3 rndPos = new Vector3(rndX, 1000, rndZ);
            if(Physics.Raycast(rndPos, Vector3.down, out RaycastHit hit))
            {
              Instantiate(Box10, hit.point + Vector3.up*2f, Quaternion.identity);
               
                Debug.Log("Box10 placed");
            }
                
        }
        for (int i = 0; i<= count50; i++)
        {
            float rndX = Random.Range(10,991);
            float rndZ = Random.Range(10,991);
            Vector3 rndPos = new Vector3(rndX, 1000, rndZ);
            if(Physics.Raycast(rndPos, Vector3.down, out RaycastHit hit))
            {
              Instantiate(Box50, hit.point + Vector3.up*2f, Quaternion.identity);
                
                Debug.Log("Box50 placed");
            }
                
        }
         for (int i = 0; i<= count100; i++)
        {
            float rndX = Random.Range(10,991);
            float rndZ = Random.Range(10,991);
            Vector3 rndPos = new Vector3(rndX, 1000, rndZ);
            if(Physics.Raycast(rndPos, Vector3.down, out RaycastHit hit))
            {
              Instantiate(Box100, hit.point + Vector3.up*2f, Quaternion.identity);
                Debug.Log("Box100 placed");
            }
                
        }
    }
}

