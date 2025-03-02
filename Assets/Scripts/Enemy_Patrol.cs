using UnityEngine;

public class Enemy_Patrol : MonoBehaviour
{
    public float speed;
    public int damage = 10;
    //public float maxHealth = 20f; //nuevo
    //public float health;//nuevo

    public Transform pointA;
    public Transform pointB;
    public Transform targetPoint;

    public GameObject coinPrefab;

    public Health_Player healthPlayer; //para poder acceder desde este codigo

    void Start()
   {
       targetPoint = pointA; //Empiezo en el punto A      
   }

   // Update is called once per frame
   void Update()
   {
        if (transform.position == targetPoint.position) //Comprueba que el punto donde esta era el objetivo
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA; //Dos puntos donde puede estar.
        }
        //Para que no se mueva en el eje y, como el Movement_character
        Vector3 targetPosition = new Vector3(targetPoint.position.x, 0.5f, targetPoint.position.z);        
        //Pongo 0.5f porque si no se hunde en el suelo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);            
   }

    private void OnCollisionEnter(Collision collision) //Para dañar al jugador si se chocan
    {
        if (collision.gameObject.tag == "Player") //Comprueba que choca con el jugador
        {
            healthPlayer.TakeDamage(damage);
        }
    }
    public void CreateCoin()
    {
        Instantiate(coinPrefab, targetPoint.position, targetPoint.rotation);
    }
    

}
