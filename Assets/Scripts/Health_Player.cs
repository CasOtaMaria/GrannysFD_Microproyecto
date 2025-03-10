using UnityEngine;
using UnityEngine.SceneManagement;

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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void TakeHealth(int healthTaken)
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
