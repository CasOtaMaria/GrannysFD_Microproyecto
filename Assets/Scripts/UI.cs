using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public Health_Player healthPlayer;

    public TextMeshProUGUI coinsText;
    public CoinManager coinManager;
    //public GameObject coinPrefab;


    void Start()
    {
        healthPlayer.health = healthPlayer.maxHealth;
    }

    void Update()
    {
        healthText.text = healthPlayer.health.ToString() + "/" + healthPlayer.maxHealth.ToString();
        coinsText.text = coinManager.coinCount.ToString();
    }

}
