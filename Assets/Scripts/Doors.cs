using UnityEngine;

public class Doors : MonoBehaviour
{
    
    public int keyToOpen; //para indicar en la escena que llave necesita
    //1 = fruit / 2=fish/3=meat

    public GameObject instructionsUI;
    public GameManager gameManager;

    public Animator animator;
    bool isOpen = false;

    private bool playerInRange = false;
    private bool keyPressed = false;

    public GameObject lockDoor;

    /*
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador esta en el rango de la puerta");
            //instructionsUI.SetActive(true);
            //playerInRange = true;
            TryOpen();          
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador esta fuera del rango de la puerta");
            //instructionsUI.SetActive(false);
                        //playerInRange = false;
        }
    }
    void TryOpen()
    {
        //HasKey();

        Debug.Log("Intenta abrirla");
        if (Input.GetKeyDown(KeyCode.Q))
        {
           
            /*
            if (isOpen)
            {
                if (gameManager.HasKey(keyToOpen))
                {
                    DoorOpen();
                }
                else
                {
                    Debug.Log("I don't have the ticket for this...");
                }
            }*/
    /*
        }     
    }
    void HasKey()
    {
        if ((keyToOpen == 1) && (gameManager.keyFruit > 0))
        {
            Debug.Log("Tienes la llave");
            DoorOpen();
            gameManager.keyFruit--;           
        }
        if ((keyToOpen == 2) && (gameManager.keyFish > 0))
        {
            DoorOpen();
            gameManager.keyFish--;
        }
        if ((keyToOpen == 3) && (gameManager.keyMeat > 0))
        {
            DoorOpen();
            gameManager.keyMeat--;
        }   
    }
    void DoorOpen()
    {
        //isOpen = true;
        //animator.SetTrigger("Open");
        //Invoke("DestroyDoor", 1.5f);    
        DestroyDoor();
    }

    void DestroyDoor()
    {
        Destroy(gameObject);
    }
*/
    private void Start()
    {
        instructionsUI.SetActive(false);

    }
    void Update()
    {
        if (playerInRange && !keyPressed && Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Intentando abrir la puerta");
            keyPressed = true;
            TryOpen();
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está en el rango de la puerta");
            instructionsUI.SetActive(true);
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está fuera del rango de la puerta");
            instructionsUI.SetActive(false);
            playerInRange = false;
            keyPressed = false;
        }
    }
    void TryOpen()
    {
        HasKey();
    }

    void HasKey()
    {
        if (keyToOpen == 1 && gameManager.keyFruitSO._value > 0)
        {
            Debug.Log("Tienes la llave de fruta");
            DoorOpen();
            //gameManager.keyFruitSO._value--;
        }
        else if (keyToOpen == 2 && gameManager.keyFishSO._value > 0)
        {
            Debug.Log("Tienes la llave de pescado");
            DoorOpen();
            //gameManager.keyFishSO._value--;
        }
        else if (keyToOpen == 3 && gameManager.keyMeatSO._value > 0)
        {
            Debug.Log("Tienes la llave de carne");
            DoorOpen();
            //gameManager.keyMeatSO._value--;
        }
        else
        {
            Debug.Log("No tienes la llave correcta");
        }
    }

    void DoorOpen()
    {
        Debug.Log("Puerta abierta");
        animator.SetBool("isOpen", true);
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor"))
        {
            animator.SetTrigger("finishOpen");
        }       
        Destroy(lockDoor);  // destruye el bloqueo de la puerta

    }
}
