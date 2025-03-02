using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float damage = 5;
    public EnemyPatrol_Health enemyPatrolHealth;
   
    void Awake()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            enemyPatrolHealth.TakeDamage(damage);     
        }        
    }
}
