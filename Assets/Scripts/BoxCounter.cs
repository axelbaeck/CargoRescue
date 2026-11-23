using UnityEngine;

public class TargetArea : MonoBehaviour
{

    private int Collected = 0;
    public Transform Boxes;
  

    void Update()
    {
       if (Collected >= Boxes.childCount)
        {
            Debug.Log("You Won");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boxes")
        {
            Collected++;
            Debug.Log(Collected);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Boxes")
        {
            Collected--;
            Debug.Log(Collected);
        }
    }
}
