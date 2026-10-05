using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public InputAction attackAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.IsPressed())
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
