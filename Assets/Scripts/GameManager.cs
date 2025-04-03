using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Movement_Character movementCharacter;
    public PauseMenu pauseMenu;
    public GameObject optionsMenu;

    //INVENTARIO
    [SerializeField]
    public IntSO coinCountSO; 

    public int numBullets01 = 0;
    public int numBullets02 = 0;
    public int numCandy = 0;
    public int numTea = 0;

    public int keyFruit = 0;
    public int keyFish = 0;
    public int keyMeat = 0;

    //TIPOS DE BALAS
    public GameObject bullet01Prefab;
    public GameObject bullet02Prefab;

    public float speedUpgrade = 5f;

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
    }

    public void UpgradeBullets()
    {
        movementCharacter.bulletsPrefab = bullet02Prefab;
    }
    public void UpgradeSpeed()
    {
        movementCharacter.speed = speedUpgrade;
    }
    public void ResetDataSO()
    {
        coinCountSO._value = 0;
        Debug.Log("Coin count has been reset to: " + coinCountSO._value);
    }


}

