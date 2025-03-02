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
    void Update()
    {
    }
    
    public void TakeDamage(float damageTaken)
    {
        health =- damageTaken;
        if (health <= 0)
        {
            //enemyPatrol.CreateCoin();
            Destroy(gameObject);
        }
    }


}
