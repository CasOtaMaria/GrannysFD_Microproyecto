using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float damage;
    public EnemyPatrol_Health enemyPatrolHealth;
    public GameManager inventoryPlayer;

    /*
    void Update()
    {
        if ((inventoryPlayer.numBullets01 == 1) && (inventoryPlayer.numBullets02==0))
        {
            damage = 5;
        }
        if ((inventoryPlayer.numBullets01 == 1) && (inventoryPlayer.numBullets02 == 1))
        {
            damage = 8;
        }
    }*/

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

        /* //CODIGO ANTIGUO
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            enemyPatrolHealth.TakeDamage(damage);     
        }*/       
    }
}
