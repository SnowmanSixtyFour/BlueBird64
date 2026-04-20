using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    public CharacterController controller;

    public float
        movementSpeed = 0.5f, // Movement Speed of Player

        cameraRotationSpeed = 0.5f, // Amount to Rotate Player by
        yRotation = 0; // Current Rotation of Player

    // --- METHODS ---

    public void Update()
    {
        // Get Input
        float y = Input.GetAxis("Horizontal");

        // Calculate Movement
        yRotation += y * cameraRotationSpeed;

        // Apply Move
        controller.transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        // Rotate Player
        transform.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
}
