using UnityEngine;

public class EnemyPatrol_Health : MonoBehaviour
{  
    public float maxHealth = 20f;
    public float health;
    public Enemy_Patrol enemyPatrol;
    
    void Start()
    {
        health = maxHealth;
    }   
    public void TakeDamage(float damageTaken)
    {
        if (health > 0)
        {
            health -= damageTaken;
            health = Mathf.Max(health, 0);  //hago que la salud sea positiva (porque antes solo me salia neg)
            Debug.Log("Salud restante: " + health);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            enemyPatrol.CreateCoin();
        }     
    }
}
