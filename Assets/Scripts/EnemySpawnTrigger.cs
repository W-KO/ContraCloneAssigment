using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    Spawner spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerCharacterController>() != null)
        {
            spawner.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Colli)
}
