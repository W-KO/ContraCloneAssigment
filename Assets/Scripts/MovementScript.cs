using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class CharacterMovement : MonoBehaviour
{

    Rigidbody2D rb;
    bool isOnGround;
    float playerSpeed;

    // These variables are to hold the Action references
    InputAction moveAction;
    InputAction jumpAction;

    public int jumpHeight;

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 0.1f);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSpeed = 9.0f;
        jumpHeight = 12;

        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    void Update()
    {
        // Read the "Move" action value, which is a 2D vector
        Vector2 moveValue = moveAction.ReadValue<Vector2>() * playerSpeed;

        if (jumpAction.WasPressedThisFrame())
        {
            Debug.Log("Hi");
            rb.linearVelocity = new Vector2(moveValue.x, jumpHeight);
            
        }

        // your movement code here
        rb.linearVelocityX = moveValue.x;
    }
}

