using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    public CharacterController player;

    private float
        movementSpeed = 1f, // Movement Speed of Player

        rotationSpeed = 0.5f, // Amount to Rotate Player by
        playerRotation = 0, // Current Rotation of Player

        // New Position
        zPos = 0f;

    // --- METHODS ---

    public void Update()
    {
        // Get Input
        float y = Input.GetAxis("Horizontal");

        // Calculate Movement
        playerRotation += y * rotationSpeed;

        zPos = (1 * movementSpeed * Time.deltaTime);

        // Apply Move
        player.transform.Translate(0, 0, zPos);

        // Rotate Player
        transform.localRotation = Quaternion.Euler(0, playerRotation, 0);
    }
}
