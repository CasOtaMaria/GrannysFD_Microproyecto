using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Health : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public Health_Player healthPlayer;

    void Start()
    {
        healthPlayer.health = healthPlayer.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = healthPlayer.health.ToString() + "/" + healthPlayer.maxHealth.ToString();
    }
}
