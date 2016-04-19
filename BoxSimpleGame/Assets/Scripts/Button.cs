using UnityEngine;

public class Button : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }
}