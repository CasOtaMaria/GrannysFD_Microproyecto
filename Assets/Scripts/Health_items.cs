using UnityEngine;

public class Health_items : MonoBehaviour
{//SOLO PRUEBA
    public int candy = 10;
    public int tea = 15;
    public Health_Player healthPlayer;

    public Shop shop;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && (shop.numCandy >0))
        {
            shop.numCandy--;
            healthPlayer.TakeHealth(candy);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            //shop.numTeaPlayerT--;
            healthPlayer.TakeHealth(tea);
        }
        //Input.GetKeyDown(KeyCode.Q);
    }

}
