using UnityEngine;
using UnityEngine.Tilemaps;

public class RunnerController : MonoBehaviour
{

    public CharacterMovement movescript;
    public BoxCollider2D groundcheck;

    bool isOnGround = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movescript.moveValue.x = 1;

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
            movescript.jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerCharacterController>()) {
            Damagable HP = collision.gameObject.GetComponent<Damagable>();

            HP.TakeDamage(1);

        }
    }

}
