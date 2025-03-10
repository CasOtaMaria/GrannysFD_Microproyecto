using UnityEngine;

public class Health_items : MonoBehaviour
{//SOLO PRUEBA
    public int candy = 5;
    public int tea = 10;
    public Health_Player healthPlayer;

    public Shop shop;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && (shop.numCandy >0))
        {
            shop.numCandy--;
            healthPlayer.TakeHealth(candy);
        }
        if (Input.GetKey(KeyCode.Alpha2) && (shop.numTea > 0))
        {
            shop.numTea--;
            healthPlayer.TakeHealth(tea);
        }       
    }

}
