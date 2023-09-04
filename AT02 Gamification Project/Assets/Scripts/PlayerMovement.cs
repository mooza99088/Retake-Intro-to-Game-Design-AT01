using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController characterController;
    private Transform cameraTransform;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        // Find the main camera in the scene and get its transform
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction relative to the camera
        Vector3 moveDirection = cameraTransform.forward * verticalInput + cameraTransform.right * horizontalInput;
        moveDirection.y = 0f; // Ensure the player stays grounded

        // Normalize the movement direction to prevent diagonal movement from being faster
        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();
        }

        // Move the player using Character Controller
        if (moveDirection.magnitude >= 0.1f)
        {
            // Apply movement speed and deltaTime for smooth movement
            Vector3 moveVector = moveDirection * moveSpeed * Time.deltaTime;

            // Rotate the player to match the camera's forward direction
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);

            // Use the Character Controller methods for movement
            characterController.Move(moveVector);
        }
    }
}


