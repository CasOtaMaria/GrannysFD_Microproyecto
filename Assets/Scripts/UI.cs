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
        //healthPlayer.healthSO._value = 100;
    }

    void Update()
    {
        healthText.text =healthPlayer.healthSO.Value+"" + "/" + 100;
        //coinsText.text = inventoryPlayer.coinCountSO.ToString();
        coinsText.text = gameManager.coinCountSO.Value+"";

        candy.text = gameManager.numCandySO._value.ToString(); //Accede a la cantidad de caramelos comprados en la tienda
        tea.text = gameManager.numTeaSO._value.ToString();  
    }

}
