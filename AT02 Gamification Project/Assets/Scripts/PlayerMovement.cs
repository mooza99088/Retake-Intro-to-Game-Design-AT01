using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float gravity = 30f;
    [SerializeField] private float defaultMoveSpeed = 3.5f;

    private Vector3 motionStep;
    private float velocity = 0f;
    private float currentSpeed = 0f;
    private CharacterController controller;


    public bool CanMove { get; set; } = true;

    private void Awake()
    {
        TryGetComponent(out controller);
    }

    void Start()
    {
        currentSpeed = defaultMoveSpeed;
    }

    private void FixedUpdate()
    {
        if(CanMove == true)
        {
            if(controller.isGrounded == true)
            {
                velocity =-gravity * Time.deltaTime;
            }
            else
            {
                velocity -= gravity * Time.deltaTime;
            }
        }
    }

    void Update()
    {
        ApplyMovement();
    }
    

    private void ApplyMovement()
    {
        motionStep = Vector3.zero;
        motionStep += transform.forward * Input.GetAxisRaw("Vertical");
        motionStep += transform.right * Input.GetAxisRaw("Horizontal");
        motionStep = currentSpeed * motionStep.normalized;
        motionStep.y += velocity;
        controller.Move(motionStep * Time.deltaTime);
    }
}


