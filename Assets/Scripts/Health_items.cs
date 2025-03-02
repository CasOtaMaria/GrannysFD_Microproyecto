using UnityEngine;

public class Health_items : MonoBehaviour
{//SOLO PRUEBA
    public int candy = 10;
    public int tea = 15;
    public Health_Player healthPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            healthPlayer.TakeHealth(candy);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            healthPlayer.TakeHealth(tea);
        }

    }

}
