using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class CharacterMovement : MonoBehaviour
{

    Rigidbody2D rb;

    bool isOnGround;
    public float speed;

    // These variables are to hold the Action references

    public Vector2 moveValue;
    bool jumpRequested;
    public int jumpHeight;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 9.0f;
        jumpHeight = 12;
    }

    void Update()
    {
        // Read the "Move" action value, which is a 2D vector
        //Vector2 moveValue = moveAction.ReadValue<Vector2>() * playerSpeed;

        // ground check using small collision box (no wall jumping) 
        

        if (jumpRequested)
        {
            // Debug.Log("Hi");
            jump();
            
        }

        // your movement code here
        rb.linearVelocityX = (moveValue.x * speed);
    }


    public void jump() {
        rb.linearVelocityY = jumpHeight;
    }

}

