using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("----------PLAYER AND UI----------")]
    public Movement_Character movementCharacter;
    public Health_Player healthPlayer;  
    public PauseMenu pauseMenu;
    public GameObject optionsMenu;
    public GameObject deathScreen;
    public GameObject winScreen;
    public SoundManager soundManager;
    public bool isDead= false;

    [SerializeField] public FloatSO speedSO;

    [Header("----------INVENTORY----------")]
    [SerializeField] public IntSO coinCountSO; 
    [SerializeField] public IntSO numBul01SO;
    [SerializeField] public IntSO numBul02SO;
    [SerializeField] public IntSO numCandySO;
    [SerializeField] public IntSO numTeaSO;
    
    [SerializeField] public IntSO keyFruitSO;
    [SerializeField] public IntSO keyMeatSO;
    [SerializeField] public IntSO keyFishSO;

    [Header("----------TIENDA----------")]
    [SerializeField] public IntSO numBull1ShopQSO;
    [SerializeField] public IntSO numBull2ShopQSO;
    [SerializeField] public IntSO speedShopQSO;

    [Header("----------UPGRADES----------")] //UPGRADES
    public Shop shop;
    public GameObject bullet01Prefab;
    public GameObject bullet02Prefab;
    //public float speedUpgrade = 5f;

    [Header("----------WIN ITEMS----------")]
    [SerializeField] public IntSO fruitSO;
    [SerializeField] public IntSO meatSO;
    [SerializeField] public IntSO fishSO;

    private void Start()
    {
        optionsMenu.SetActive(false);
        deathScreen.SetActive(false);
        winScreen.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.PauseGame();
        }
        if ((numBul02SO._value>0)&& (numBul01SO._value > 0))
        {
            UpgradeBullets();
        }
        if (isDead == true)
        {
            GameOver();
        }
    }
    public void UpgradeBullets()
    {
        movementCharacter.bulletsPrefab = bullet02Prefab;
    }
    public void UpgradeSpeed()
    {
        speedSO._value = 4.5f;
    }
    public void GameOver()
    {
        soundManager.musicSource.Stop();
        soundManager.sfxSource.Stop();  
        deathScreen.SetActive(true);
    }
    public void Win()
    {
        winScreen.SetActive(true);
    }
    public void ResetDataSO()
    {
        //MANAGER
        coinCountSO._value = 0;
        Debug.Log("Coin count has been reset to: " + coinCountSO._value);
        healthPlayer.healthSO._value = 100;
        Debug.Log("Health has been reset to: " + healthPlayer.healthSO._value);
        speedSO._value = 3f;
        Debug.Log("Health has been reset to: " + speedSO._value);

        //UPGRADES
        numBul01SO._value = 0;
        Debug.Log("Bullets 01 reset to: " + numBul01SO._value);
        numBul02SO._value = 0;
        Debug.Log("Bullets 02 reset to: " + numBul02SO._value);

        //ITEMS
        numCandySO._value = 0;
        Debug.Log("Candy reset to: " + numCandySO._value);
        numTeaSO._value = 0;
        Debug.Log("Tea reset to: " + numTeaSO._value);
        keyFruitSO._value = 0;
        Debug.Log("K Fruit reset to: " + keyFruitSO._value);
        keyFishSO._value = 0;
        Debug.Log("K Fish reset to: " + keyFruitSO._value);
        keyMeatSO._value = 0;
        Debug.Log("K Meat reset to: " + keyFruitSO._value);

        //SHOP
        speedShopQSO._value = 1;
        numBull1ShopQSO._value = 1;
        numBull2ShopQSO._value = 1;

        //WIN ITEMS
        fruitSO._value = 0;
        meatSO._value = 0;
        fishSO._value = 0;
    }
}

