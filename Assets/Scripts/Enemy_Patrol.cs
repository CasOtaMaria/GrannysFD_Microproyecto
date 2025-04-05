using System.Runtime.CompilerServices;
using UnityEngine;
//using UnityEngine.Apple;
//using static UnityEngine.EventSystems.StandaloneInputModule;

public class Enemy_Patrol : MonoBehaviour
{
    public float speed;
    public int damage = 10;

    public Transform pointA;
    public Transform pointB;
    public Transform targetPoint;

    public GameObject coinPrefab;
    public Transform itemSpawnPoint;

    public Health_Player healthPlayer; //para poder acceder desde este codigo

    public Animator animator;
    public SoundManager soundManager;
    
    void Start()
    {
       targetPoint = pointA; //Empiezo en el punto A      
    }
  
   void Update()
   {
        if (transform.position == targetPoint.position) //Comprueba que el punto donde esta era el objetivo
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA; //Dos puntos donde puede estar.
        }

        //Para que no se mueva en el eje y, como el Movement_character
        Vector3 targetPosition = new Vector3(targetPoint.position.x, 0.5f, targetPoint.position.z);               
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        Animations();
   }

    private void OnCollisionEnter(Collision collision) //Para dañar al jugador si se chocan
    {
        if (collision.gameObject.tag == "Player") //Comprueba que choca con el jugador
        {
            healthPlayer.TakeDamage(damage);
            soundManager.sfxSource.PlayOneShot(soundManager.damageClip);
        }
    }
    public void CreateCoin()
    {
        Instantiate(coinPrefab, itemSpawnPoint.position, Quaternion.identity);
    }
    
    private void Animations()
    {
      
        if (targetPoint == pointA) //Comparo, no igualo
        {
            animator.SetBool("Destination", false);
        }
        else               
        {
            animator.SetBool("Destination", true);
        }
    }

    //PARA VER BIEN LOS PUNTOS
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

}
