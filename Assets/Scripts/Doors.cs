using UnityEngine;

public class Doors : MonoBehaviour
{
    
    public int keyToOpen; //para indicar en la escena que llave necesita
    //1 = fruit / 2=fish/3=meat

    public GameObject instructionsUI;
    public GameManager gameManager;

    //public Animator animator;
    //bool isOpen = false;

    private bool playerInRange = false;
    private bool keyPressed = false;

    public Camera cameraChange;
    CameraManager cameraManager; 
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
            playerInRange = true;  // El jugador está en el rango
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está fuera del rango de la puerta");
            instructionsUI.SetActive(false);
            playerInRange = false;  // El jugador salió del rango
            keyPressed = false;
        }
    }
    void TryOpen()
    {
        HasKey();
    }

    void HasKey()
    {
        // Comprobación de las llaves necesarias para abrir la puerta
        if (keyToOpen == 1 && gameManager.keyFruit > 0)
        {
            Debug.Log("Tienes la llave de fruta");
            DoorOpen();
            gameManager.keyFruit--;
        }
        else if (keyToOpen == 2 && gameManager.keyFish > 0)
        {
            Debug.Log("Tienes la llave de pescado");
            DoorOpen();
            gameManager.keyFish--;
        }
        else if (keyToOpen == 3 && gameManager.keyMeat > 0)
        {
            Debug.Log("Tienes la llave de carne");
            DoorOpen();
            gameManager.keyMeat--;
        }
        else
        {
            Debug.Log("No tienes la llave correcta");
        }
    }

    void DoorOpen()
    {
        Debug.Log("Puerta abierta");
        Destroy(gameObject);  // Destruye la puerta


        //Invoke("ChangeCamera", 1f);
    }
    /*
    public void ChangeCamera()
    {
        cameraManager.cameraUsing = cameraChange;
    }*/
}
