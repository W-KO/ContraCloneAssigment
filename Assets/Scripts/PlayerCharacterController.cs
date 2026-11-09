using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;


// Aiming, Shooting
// Jumping, Running

// doesnt move player just grabs input
// hence the name "Controller"


public class PlayerCharacterController : MonoBehaviour
{

    public BoxCollider2D groundcheck;
    bool isOnGround = false;

    public Spawner spawner;
    InputAction attackAction;

    public CharacterMovement movescript;

    InputAction moveAction;
    InputAction jumpAction;
    InputAction lookAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");

        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        lookAction = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {

        

        spawner.isSpawning = attackAction.IsPressed();

        movescript.moveValue = moveAction.ReadValue<Vector2>();

        if (isOnGround && jumpAction.IsPressed())
        {
            movescript.jump();
        }

        // use move actions to aim
        Vector2 lookValue = lookAction.ReadValue<Vector2>();
        spawner.transform.right = lookValue;
        Debug.DrawRay(spawner.transform.position, lookValue);
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Tilemap>())
        {
            isOnGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Tilemap>()) 
        {
            isOnGround = false;
        }
    }

}
