using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    //VIDA
    public TextMeshProUGUI healthText;
    public Health_Player healthPlayer;
    //MONEDAS
    public TextMeshProUGUI coinsText;

    //ITEMS
    public GameManager gameManager;
    public TextMeshProUGUI candy;
    public TextMeshProUGUI tea;

    void Start()
    {
        healthPlayer.health = healthPlayer.maxHealth;
    }

    void Update()
    {
        healthText.text = healthPlayer.health.ToString() + "/" + healthPlayer.maxHealth.ToString();
        //coinsText.text = inventoryPlayer.coinCountSO.ToString();
        coinsText.text = gameManager.coinCountSO.Value+"";

        candy.text = gameManager.numCandy.ToString(); //Accede a la cantidad de caramelos comprados en la tienda
        tea.text = gameManager.numTea.ToString();  
    }

}
