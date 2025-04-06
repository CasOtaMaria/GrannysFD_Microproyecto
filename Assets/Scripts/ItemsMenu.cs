using UnityEngine;

public class ItemsMenu : MonoBehaviour
{
    public GameObject itemsMenuUI;
    public bool openItemsMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
        
    }

    public void AbrirItemsMenu()
    {
        itemsMenuUI.SetActive(true);
        openItemsMenu = true;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ocultar();
        }
    }

    void Ocultar()
    {
        itemsMenuUI.SetActive(false);
        openItemsMenu = false;

    }
}

