using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_Player : MonoBehaviour
{
    /*
    public int health;
    public int maxHealth = 100;
    */
    [SerializeField] public IntSO healthSO;
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //healthSO._value = 100;
    }

    public void TakeDamage(int damageTaken)
    {
        healthSO._value -= damageTaken;
        if (healthSO._value <= 0)
        {       
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameManager.isDead=true;
            Destroy(gameObject);
            Debug.Log("El jugador se ha muerto");
        }
    }
    public void TakeHealth(int healthTaken)
    {
        if (healthSO._value + healthTaken > 100)
        {
            healthSO._value = 100;
        }
        else
        {
            healthSO._value = healthSO._value + healthTaken;
        }
    }
}
