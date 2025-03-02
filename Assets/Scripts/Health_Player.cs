using UnityEngine;

public class Health_Player : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeHealth(int healthTaken) //REVISAR
    {

        if (health + healthTaken > 100)
        {
            health = maxHealth;
        }
        else
        {
            health=health + healthTaken;
        }
    }
}
