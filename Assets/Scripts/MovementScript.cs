using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class CharacterMovement : MonoBehaviour
{

    Rigidbody2D rb;


    public BoxCollider2D groundcheck;
    public TilemapCollider2D tiles;

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

        // ground check using small collision box (no wall jumping)
        if (groundcheck.IsTouching(tiles))
        {
            isOnGround = true;
        } else
        {
            isOnGround = false;
        }

        if (jumpAction.WasPressedThisFrame() && isOnGround)
        {
            // Debug.Log("Hi");
            rb.linearVelocityY = jumpHeight;
            
        }

        // your movement code here
        rb.linearVelocityX = moveValue.x;
    }
}

