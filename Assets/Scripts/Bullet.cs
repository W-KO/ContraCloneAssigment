using UnityEngine;

public class Bullet : MonoBehaviour
{


    public Vector3 Velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
