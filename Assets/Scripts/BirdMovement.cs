using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    // Object

    // Player
    public CharacterController controller;

    // Properties

    // Movement
    public float speed = 12f;

    // --- METHODS ---

    public void Update()
    {
        // Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calculate Movement
        Vector3 move = transform.right * x + transform.forward * z;
        
        // Move Player
        controller.Move(move * speed * Time.deltaTime);
    }
}
