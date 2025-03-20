using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Movement_Character movementCharacter;
    
    //INVENTARIO
    public int coinCount;   
    public int numBullets01 = 0;
    public int numBullets02 = 0;
    public int numCandy = 0;
    public int numTea = 0;

    //TIPOS DE BALAS
    public GameObject bullet01Prefab;
    public GameObject bullet02Prefab;

    public void UpgradeBullets()
    {
        movementCharacter.bulletsPrefab = bullet02Prefab;
    }

}
