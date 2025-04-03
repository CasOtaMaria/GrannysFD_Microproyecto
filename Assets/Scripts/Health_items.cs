using UnityEngine;

public class Health_items : MonoBehaviour
{
    public int candy = 5;
    public int tea = 10;
    public Health_Player healthPlayer;

    public GameManager inventoryPlayer;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && (inventoryPlayer.numCandySO._value>0))
        {
            inventoryPlayer.numCandySO._value--;
            healthPlayer.TakeHealth(candy);
        }
        if (Input.GetKey(KeyCode.Alpha2) && (inventoryPlayer.numTeaSO._value > 0))
        {
            inventoryPlayer.numTeaSO._value--;
            healthPlayer.TakeHealth(tea);
        }
    }

}
