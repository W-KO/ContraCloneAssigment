using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public InputAction attackAction;
    float timeSinceLastSpawn = 0.0f;
    public float timeBetweenSpawns = 3.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.IsPressed() && timeSinceLastSpawn > timeBetweenSpawns)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            timeSinceLastSpawn = 0.0f;
        }

        timeSinceLastSpawn += Time.deltaTime;
    }
}
