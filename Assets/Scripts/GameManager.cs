using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Movement_Character movementCharacter;
    public PauseMenu pauseMenu;
    public GameObject optionsMenu;
    
    //INVENTARIO
    public int coinCount;   
    public int numBullets01 = 0;
    public int numBullets02 = 0;
    public int numCandy = 0;
    public int numTea = 0;

    //TIPOS DE BALAS
    public GameObject bullet01Prefab;
    public GameObject bullet02Prefab;

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
    
}

