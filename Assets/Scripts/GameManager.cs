using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Movement_Character movementCharacter;
    public Health_Player healthPlayer;  
    public PauseMenu pauseMenu;
    public GameObject optionsMenu;

    [SerializeField]
    public FloatSO speedSO;


    //INVENTARIO
    [SerializeField]
        public IntSO coinCountSO; 
    [SerializeField]
        public IntSO numBul01SO;
    [SerializeField]
        public IntSO numBul02SO;
    [SerializeField]
        public IntSO numCandySO;
    [SerializeField]
        public IntSO numTeaSO;
    //keys
    [SerializeField]
        public IntSO keyFruitSO;
    [SerializeField]
        public IntSO keyMeatSO;
    [SerializeField]
        public IntSO keyFishSO;
    //public int numBullets01 = 0;
    //public int numBullets02 = 0;
    //public int numCandy = 0;
    //public int numTea = 0;
    //public int keyFruit = 0;
    //public int keyFish = 0;
    //public int keyMeat = 0;

    //UPGRADES
    public GameObject bullet01Prefab;
    public GameObject bullet02Prefab;
    //public float speedUpgrade = 5f;

    private void Start()
    {
        optionsMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.PauseGame();
        }
        if((numBul02SO._value>0)&& (numBul01SO._value > 0))
        {
            UpgradeBullets();
        }
    }

    public void UpgradeBullets()
    {
        movementCharacter.bulletsPrefab = bullet02Prefab;
    }
    public void UpgradeSpeed()
    {
        speedSO._value = 5f;
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
    }


}

