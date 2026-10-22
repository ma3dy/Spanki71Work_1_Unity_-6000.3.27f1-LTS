using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    public float rotationSpeed = 50.0f;

    void Start()
    {
        Debug.Log("Rotation script started");
    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}