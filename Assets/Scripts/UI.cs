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

    public Image fruitsIcon;
    public Image fishIcon;
    public Image meatIcon;


    void Start()
    {
        fruitsIcon.enabled = false;
        fishIcon.enabled = false;
        meatIcon.enabled = false;
    }

    void Update()
    {
        healthText.text =healthPlayer.healthSO.Value+"" + "/" + 100;      
        coinsText.text = gameManager.coinCountSO.Value+"";

        candy.text = gameManager.numCandySO._value.ToString(); //Accede a la cantidad de caramelos comprados en la tienda
        tea.text = gameManager.numTeaSO._value.ToString();  

        if (gameManager.fruitSO._value > 0)
        {
            fruitsIcon.enabled = true;
        }
        else
        {
            fruitsIcon.enabled = false;
        }
        if (gameManager.fishSO._value > 0)
        {
            fishIcon.enabled = true;
        }
        else
        {
            fishIcon.enabled = false;
        }
        if (gameManager.meatSO._value > 0)
        {
            meatIcon.enabled = true;
        }
        else
        {
            meatIcon.enabled = false;
        }
    }
    

}
