using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    public Spawner spawner;
    //public Collider2D trigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerCharacterController>() != null)
        {
            spawner.isSpawning = true;
            spawner.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerCharacterController>() != null)
        {
            spawner.isSpawning = false;
            spawner.gameObject.SetActive(false);
        }
    }
}
