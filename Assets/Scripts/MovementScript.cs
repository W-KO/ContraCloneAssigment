using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    // These variables are to hold the Action references
    InputAction moveAction;

    private void Start()
    {
        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        // Read the "Move" action value, which is a 2D vector
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        // your movement code here
        transform.Translate(new Vector3(moveValue.x * 0.05f, moveValue.y * 0.05f, 0));
    }
}