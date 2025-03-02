using UnityEngine;

public class Movement_Character : MonoBehaviour
{
    public float velocidad;
    public Rigidbody rbCharacter;
    private Vector2 inputMov; //El movimiento del personaje sera 2D (ejes x,z)

    //public GameObject coinPrefab;
    public CoinManager coinManager;

    private void Start()
    {
       
    }

    void Update()
    {
        inputMov.x = Input.GetAxis("Horizontal"); //Accede al Input System Package donde los inputs de las teclas ya están definidos
        inputMov.y = Input.GetAxis("Vertical");
        inputMov.Normalize(); //Para que sea un vector unitario (que no aumente la velocidad al moverse en diagonal)

        rbCharacter.linearVelocity = new Vector3(inputMov.x*velocidad, 0f, inputMov.y*velocidad); //0f porque no quiero que salte en ningún momento
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinManager.coinCount++;
        }
    }
}
    
