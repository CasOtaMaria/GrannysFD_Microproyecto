using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement_Character : MonoBehaviour
{
    public float speed;
    public Rigidbody rbCharacter;
    private Vector2 inputMov; //El movimiento del personaje sera 2D (ejes x,z)

    public GameManager coinManager;

    public Transform bulletsSpawn;
    public GameObject bulletsPrefab;
    public float bulletsSpeed=10;
    private float lastBullet;
    public float bulletDelay=0.5f;

    public Animator animator;
    private bool moving;

    private void Start()
    {
       
    }

    void Update()
    {
        //MOVEMENT
        inputMov.x = Input.GetAxis("Horizontal"); //Accede al Input System Package donde los inputs de las teclas ya están definidos
        inputMov.y = Input.GetAxis("Vertical");
        inputMov.Normalize(); //Para que sea un vector unitario (que no aumente la velocidad al moverse en diagonal)

        rbCharacter.linearVelocity = new Vector3(inputMov.x*speed, 0f, inputMov.y*speed); //0f porque no quiero que salte en ningún momento
       
        //SHOOTING
        float shootH = Input.GetAxis("HorizontalShoot"); //Accede al Input System Package donde los inputs de las teclas ya están definidos
        float shootV = Input.GetAxis("VerticalShoot");
        if((shootH != 0f || shootV != 0f) && Time.time > lastBullet + bulletDelay)
        {
            Shoot(shootH, shootV);
            lastBullet = Time.time;
        }

        //ANIMATIONS
        Animations();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinManager.coinCount++;
        }
    }
    void Shoot(float x, float y)
    {
        var bullet = Instantiate(bulletsPrefab, bulletsSpawn.position, bulletsSpawn.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().linearVelocity = new Vector3
            (   //Para mantener una velocidad constante usamos Floor y Ceil para rendondear a un num entero (abajo y arriba respectivamente)
                //La f de Mathf es de float
                (x < 0) ? Mathf.Floor(x) * bulletsSpeed : Mathf.Ceil(x) * bulletsSpeed, //EJE X
                0,//EJE Y (no queremos que se mueva en el eje)
                (y < 0) ? Mathf.Floor(y) * bulletsSpeed : Mathf.Ceil(y) * bulletsSpeed  //EJE Z           
            );
    }

    private void Animations()
    {
        moving = inputMov.magnitude > 0.1f;    

        if (moving)
        {
            animator.SetFloat("XMovement", inputMov.x);
            animator.SetFloat("YMovement", inputMov.y);
        }

        animator.SetBool("Moving", moving);
    }
}
    
