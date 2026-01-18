using UnityEngine;

public class Showlog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!");
    }

    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount);
    }
}