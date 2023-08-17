using UnityEngine;

public class rot : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0f, 45f, 0f); // Rotation speed in degrees per second

    private void Update()
    {
        // Rotate the object around its own center
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
