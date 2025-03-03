//using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public CoinManager coins;

    //JUGADOR
    private int numBullets01 = 0;
    private int numBullets02 = 0;
    public int numCandy = 0;
    private int numTea = 0;
    //COSTE
    private int costBullets01 = 5;
    private int costBullets02 = 5;
    private int costCandy = 1;
    private int costTea = 2;
    //CANTIDAD TIENDA
    private int numBullets01Shop = 1;
    private int numBullets02Shop = 1;
    //TEXTO TIENDA
    public TextMeshProUGUI numBullets01ShopT;
    public TextMeshProUGUI numBullets02ShopT;
    //TEXTO JUGADOR
    public TextMeshProUGUI numBullets01PlayerT;
    public TextMeshProUGUI numBullets02PlayerT;
    public TextMeshProUGUI numCandyPlayerT;
    public TextMeshProUGUI numTeaPlayerT;

    public void BuyBullets01()
    {
        if (coins.coinCount >= costBullets01)
        {
            coins.coinCount-=costBullets01;
            numBullets01Shop = 0;
            numBullets01 = 1;

            numBullets01ShopT.text = numBullets01Shop.ToString(); //Cantidad tienda
            numBullets01PlayerT.text = numBullets01.ToString(); //Cantidad jugador
        }
    }
    public void BuyBullets02()
    {
        if (coins.coinCount >= costBullets02)
        {
            coins.coinCount -= costBullets02;
            numBullets02Shop = 0;
            numBullets02 = 1;

            numBullets02ShopT.text = numBullets02Shop.ToString(); //Cantidad tienda
            numBullets02PlayerT.text = numBullets02.ToString(); //Cantidad jugador
        }
    }
    public void BuyCandy()
    {
        if (coins.coinCount >= costCandy)
        {
            coins.coinCount -= costCandy;
            numCandy++;
      
            //numCandyPlayerT.text = numCandy.ToString(); //Cantidad jugador
        }
    }
    public void BuyTea()
    {
        if (coins.coinCount >= costTea)
        {
            coins.coinCount -= costTea;
            numTea++;

            numTeaPlayerT.text = numTea.ToString(); //Cantidad jugador
        }
    }
}
