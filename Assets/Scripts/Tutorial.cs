using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private GameObject tutorialShop;
    public GameObject instructionsUI;

    private bool playerInRange;
    private bool openTutorial;

    public Movement_Character playerMovement;

    void Start()
    {
        tutorialShop = GameObject.FindGameObjectWithTag("TutorialShop");
        tutorialShop.SetActive(false);
        instructionsUI.SetActive(false);
    }
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Q))
        {
            if (openTutorial)
            {
                CloseTutorialShop();
            }
            else
            {
                OpenTutorialShop();
            }
        }
    }
    private void OpenTutorialShop()
    {
        Debug.Log("Se abre el tutorial");
        tutorialShop.SetActive(true);
        openTutorial = true;

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
    private void CloseTutorialShop()
    {
        Debug.Log("Se cierra el tutorial");
        tutorialShop.SetActive(false);
        openTutorial = false;

        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador está en el rango del tutorial");
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
