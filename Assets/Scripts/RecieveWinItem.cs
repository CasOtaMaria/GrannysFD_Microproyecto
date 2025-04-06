using UnityEngine;

public class RecieveWinItem : MonoBehaviour
{
    public IntSO winItem;

    public GameObject winShop;
    public GameObject instructionsUI;

    private bool playerInRange;
    private bool openWinShop;

    public Movement_Character playerMovement;

    void Start()
    {
        winShop = GameObject.FindGameObjectWithTag("WinShop");
        winShop.SetActive(false);
        instructionsUI.SetActive(false);
    }
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Q))
        {
            if (openWinShop)
            {
                CloseWinShop();
            }
            else
            {
                OpenWinShop();
            }
        }
    }
    private void OpenWinShop()
    {
        Debug.Log("Se abre el tutorial");
        winShop.SetActive(true);
        openWinShop = true;

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
    private void CloseWinShop()
    {
        Debug.Log("Se cierra la tienda");
        winItem._value = 1;
        winShop.SetActive(false);
        openWinShop = false;

        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            instructionsUI.SetActive(true);
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            instructionsUI.SetActive(false);
            playerInRange = false;
        }
    }
}
