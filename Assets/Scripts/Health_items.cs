using UnityEngine;

public class Health_items : MonoBehaviour
{
    public int candy = 5;
    public int tea = 10;
    public Health_Player healthPlayer;

    public GameManager inventoryPlayer;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && (inventoryPlayer.numCandy >0))
        {
            inventoryPlayer.numCandy--;
            healthPlayer.TakeHealth(candy);
        }
        if (Input.GetKey(KeyCode.Alpha2) && (inventoryPlayer.numTea > 0))
        {
            inventoryPlayer.numTea--;
            healthPlayer.TakeHealth(tea);
        }
    }

}
