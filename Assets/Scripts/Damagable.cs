using UnityEngine;

public class Damagable : MonoBehaviour
{

    public int HP = 3;
    public int MAXHP = 3;


    private void Update()
    {
        if (HP <= 0)
        {
            die();
        }
    }

    public void TakeDamage(int amount) { 
        if (HP > 0 )
        {
            HP -= amount;
        }
    }

    public void HealHP(int amount)
    {
        if (HP < MAXHP)
        {
            if ((HP + amount) > MAXHP) HP = MAXHP;
            else HP += amount;
        }
    }

    void die() {
        Destroy(gameObject);
    }
}
