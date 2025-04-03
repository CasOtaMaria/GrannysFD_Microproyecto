using UnityEngine;

public class OpenShop : MonoBehaviour
{
    private GameObject shop;
    public GameObject instructionsUI;

    private bool playerInRange;
    private bool openShop;

    public Movement_Character playerMovement;

    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Shop");
        shop.SetActive(false);
        instructionsUI.SetActive(false);
    }
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Q))
        {
            if (openShop)
            {
                CloseShop();
            }
            else
            {
                OpenShopMenu();
            }
        }
    }
    private void OpenShopMenu()
    {
        Debug.Log("Se abre la tienda");
        shop.SetActive(true);
        openShop = true;

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
    private void CloseShop()
    {
        Debug.Log("Se cierra la tienda");
        shop.SetActive(false);
        openShop = false;

        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está en el rango de la tienda");
            instructionsUI.SetActive(true);
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está fuera del rango de la tienda");
            instructionsUI.SetActive(false);
            playerInRange = false;
        }
    }

    /* //CODIGO ANTIGUO
   private void OnTriggerEnter(Collider collider)
   {
       if (collider.gameObject.tag == "Player")
       {
           shop.SetActive(true);
       }
   }
   private void OnTriggerExit(Collider collider)
   {
       if (collider.gameObject.tag == "Player")
       {
           shop.SetActive(false);
       }
   }
   */
}
