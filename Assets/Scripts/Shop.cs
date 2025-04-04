using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameManager gameManager;   
    
    //COSTE
    private int costBullets01 = 1;
    private int costBullets02 = 3;
    private int costCandy = 1;
    private int costTea = 2;
    private int costSpeed = 1;
    //CANTIDAD TIENDA
    private int numBullets01Shop = 1;
    private int numBullets02Shop = 1;
    private int numSpeedShop = 1;

    //TEXTO TIENDA (CANTIDAD EN TIENDA)
    public TextMeshProUGUI numBullets01ShopT;
    public TextMeshProUGUI numBullets02ShopT;
    //TEXTO JUGADOR (IU PRINCIPAL)
    public TextMeshProUGUI numBullets01PlayerT;
    public TextMeshProUGUI numBullets02PlayerT;
    public TextMeshProUGUI numCandyPlayerT;
    public TextMeshProUGUI numTeaPlayerT;

    public void BuyBullets01()
    {
        if ((gameManager.coinCountSO._value >= costBullets01)&&(numBullets01Shop!=0))
        {
            gameManager.coinCountSO._value -=costBullets01;
            numBullets01Shop = 0;
            gameManager.numBul01SO._value= 1;

            numBullets01ShopT.text = numBullets01Shop.ToString(); //Cantidad tienda
            numBullets01PlayerT.text = gameManager.numBul01SO._value.ToString(); //Cantidad jugador
        }
    } 
    public void BuyBullets02()
    {
        if ((gameManager.coinCountSO._value >= costBullets02) && (numBullets02Shop != 0))
        {
            //gameManager.UpgradeBullets();

            gameManager.coinCountSO._value -= costBullets02;
            numBullets02Shop = 0;
            gameManager.numBul02SO._value = 1;

            numBullets02ShopT.text = numBullets02Shop.ToString(); //Cantidad tienda
            numBullets02PlayerT.text = gameManager.numBul02SO._value.ToString(); //Cantidad jugador
        }
    }
    public void BuyCandy()
    {
        if (gameManager.coinCountSO._value >= costCandy)
        {
            gameManager.coinCountSO._value -= costCandy;
            gameManager.numCandySO._value++;
      
            //numCandyPlayerT.text = numCandy.ToString(); //Cantidad jugador
        }
    }
    public void BuyTea()
    {
        if (gameManager.coinCountSO._value >= costTea)
        {
            gameManager.coinCountSO._value -= costTea;
            gameManager.numTeaSO._value++;

            numTeaPlayerT.text = gameManager.numTeaSO._value.ToString(); //Cantidad jugador
        }
    }

    public void BuySpeed()
    {
        if ((gameManager.coinCountSO._value >= costSpeed) && (numBullets02Shop != 0))
        {
            gameManager.coinCountSO._value -= costSpeed;
            numSpeedShop = 0;
            gameManager.UpgradeSpeed();

            //numTeaPlayerT.text = gameManager.numTea.ToString(); //Cantidad jugador
        }
    }
}
