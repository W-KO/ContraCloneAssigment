using UnityEngine;

public class Bullet : MonoBehaviour
{


    public int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
