using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{

    //Spawner spawner;

    public GameObject prefabToSpawn;
    public bool isSpawning;
    float timeSinceLastSpawn = 0.0f;
    public float timeBetweenSpawns = 3.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawning && timeSinceLastSpawn > timeBetweenSpawns)
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
            timeSinceLastSpawn = 0.0f;
        }

        timeSinceLastSpawn += Time.deltaTime;
    }
}
