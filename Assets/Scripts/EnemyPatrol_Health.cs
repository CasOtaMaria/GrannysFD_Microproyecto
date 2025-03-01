using UnityEngine;

public class EnemyPatrol_Health : MonoBehaviour
{
    public int damage = 10;
    public Health_Player healthPlayer; //para poder acceder desde este codigo
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //Para dañar al jugador si se chocan
    {
        if (collision.gameObject.tag == "Player") //Comprueba que choca con el jugador
        {
            healthPlayer.TakeDamage(damage);
        }
    }
}
