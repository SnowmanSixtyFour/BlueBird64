using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody player;

    public AudioClip flap;

    private float
        movementSpeed = 1f, // Movement Speed

        rotationSpeed = 0.5f, // Amount to Rotate Player by
        playerRotation = 0; // Current Rotation

    public float
        gravity, // Gravity Strength
        jump, // Jump Strength
        deathBarrier; // Game Over Y Position

    public void Awake()
    {
        // Initialize Player

        player = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        // --- Movement ---

        // Get Input
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Horizontal");

        // Calculate Movement
        playerRotation += y * rotationSpeed;

        // Apply Move
        player.MovePosition(player.position + transform.forward * x * movementSpeed * Time.deltaTime);

        // Rotate Player
        player.rotation = Quaternion.Euler(0, playerRotation, 0);

        // Jump
        if (Input.GetButtonDown("Jump"))
        {
            // Add Jump Force
            player.AddForce(Vector3.up * jump, ForceMode.Impulse);

            // Play SFX
            AudioSource.PlayClipAtPoint(flap, transform.position);
        }

        // Gravity
        player.AddForce(Vector3.down * gravity, ForceMode.Force);

        // Restart Game
        if (player.position.y < 0)
        {
            // Go back to Title
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }
    }
}
