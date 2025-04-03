using UnityEngine;

public class Trap : MonoBehaviour
{
    public Animator animator;
    public Health_Player healthPlayer;
    public GameObject coinPrefab;
    public Transform itemSpawnPoint; // para el spawn de la moneda

    public GameObject specialItemPrefab;
    public bool dropSpecialItem;

    private bool isTrapActive = false;
    public int damageTrap = 15;
 
    private void OnTriggerEnter(Collider collider)
    {
        if ((collider.gameObject.tag == "Player") && !isTrapActive)
        {
            FallTrap();
        }
    }
    void FallTrap()
    {
        //healthPlayer.TakeDamage(damageTrap);
        //animator.SetBool("Fall", true);
        Invoke("DecideOutcome", 0.5f);

    }
    void DecideOutcome()
    {
        if (dropSpecialItem == false)
        {
            if (Random.Range(0, 2) == 0) // % de probabilidad
            {
                Debug.Log("Daño");
                healthPlayer.TakeDamage(damageTrap);
                Debug.Log("Salud: " + healthPlayer.healthSO._value);
            }
            else
            {
                Debug.Log("Moneda");
                CreateCoin();
            }    
        }
        else
        {
            Debug.Log("Item especial");
            CreateSpecialItem();
        }
        DestroyTrap();

    }
    void CreateCoin()
    {
        if (coinPrefab != null && itemSpawnPoint != null)
        {
            Instantiate(coinPrefab, itemSpawnPoint.position, Quaternion.identity);
        }
    }
    void CreateSpecialItem()
    {
        if (specialItemPrefab != null && itemSpawnPoint != null)
        {
            Instantiate(specialItemPrefab, itemSpawnPoint.position, Quaternion.identity);
        }
    }
    void DestroyTrap()
    {
        Destroy(gameObject);
    }
}
