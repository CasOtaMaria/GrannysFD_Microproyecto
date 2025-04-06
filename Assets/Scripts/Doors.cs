using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour
{
    
    public int keyToOpen; //para indicar en la escena que llave necesita
    //1 = fruit / 2=fish/3=meat

    public GameObject instructionsUI;
    public GameObject winConditionUI;
    public GameManager gameManager;

    public Animator animator;
    bool isOpen = false;
    public bool isFinalDoor = false;

    private bool playerInRange = false;
    private bool keyPressed = false;

    public GameObject lockDoor;

    private void Start()
    {
        instructionsUI.SetActive(false);
        winConditionUI.SetActive(false);
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
            winConditionUI.SetActive(false);
            playerInRange = false;
            keyPressed = false;
        }
    }
    void TryOpen()
    {
        if (isFinalDoor == false)
        {
            HasKey();
        }
        else
        {
            HasFinalItems();
        }
        
    }

    void HasKey()
    {
        if (keyToOpen == 1 && gameManager.keyFruitSO._value > 0)
        {
            Debug.Log("Tienes la llave de fruta");
            DoorOpen();
        }
        else if (keyToOpen == 2 && gameManager.keyFishSO._value > 0)
        {
            Debug.Log("Tienes la llave de pescado");
            DoorOpen();
        }
        else if (keyToOpen == 3 && gameManager.keyMeatSO._value > 0)
        {
            Debug.Log("Tienes la llave de carne");
            DoorOpen();
        }
        else
        {
            Debug.Log("No tienes la llave correcta");
        }
    }
    void HasFinalItems()
    {
        if (gameManager.fruitSO._value >0 && gameManager.meatSO._value > 0 && gameManager.fishSO._value > 0)
        {
            gameManager.Win();
        }
        else
        {
            winConditionUI.SetActive(true);
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
