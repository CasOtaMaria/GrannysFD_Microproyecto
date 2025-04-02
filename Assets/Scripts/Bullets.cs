using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float damage;
    private EnemyPatrol_Health enemyPatrolHealth;

    private void Start()
    {
        //Destroy(gameObject, 3f);
    }
    /*
     void OnCollisionEnter(Collision collision)
     {
         if (!collision.gameObject.CompareTag("Player")) //para evitar que la bala se destruya nada mas disparar
         {
             if (collision.gameObject.CompareTag("Enemy"))
             {
                 //accedo al script de salud (antes no lo cogia al colisionar)
                 EnemyPatrol_Health enemyHealth = collision.gameObject.GetComponent<EnemyPatrol_Health>();

                 if (enemyHealth != null) //para asegurar que encuentra el script 
                 {
                     enemyHealth.TakeDamage(damage);
                     Debug.Log("Salud restante: " + enemyHealth.health);
                 }
                 //Destroy(gameObject);
             }
             Destroy(gameObject);
         }     
         }*/

    void OnTriggerEnter(Collider collision) //
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                //accedo al script de salud (antes no lo cogia al colisionar)
                EnemyPatrol_Health enemyHealth = collision.gameObject.GetComponent<EnemyPatrol_Health>();

                if (enemyHealth != null) //para asegurar que encuentra el script 
                {
                    enemyHealth.TakeDamage(damage);
                    Debug.Log("Salud restante: " + enemyHealth.health);
                }                
            }
            Destroy(gameObject);
        }
                
    }  
}