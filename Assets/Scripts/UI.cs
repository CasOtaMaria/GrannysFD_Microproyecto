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
    public GameManager coinManager;

    //ITEMS
    public Shop shop; //Para mostrar los caramelos en la tienda y no la interfaz
    public TextMeshProUGUI candy;
    public TextMeshProUGUI tea;

    void Start()
    {
        healthPlayer.health = healthPlayer.maxHealth;
    }

    void Update()
    {
        healthText.text = healthPlayer.health.ToString() + "/" + healthPlayer.maxHealth.ToString();
        coinsText.text = coinManager.coinCount.ToString();

        candy.text = shop.numCandy.ToString(); //Accede a la cantidad de caramelos comprados en la tienda
        tea.text = shop.numTea.ToString();  
    }

}
