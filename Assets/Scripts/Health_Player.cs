using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_Player : MonoBehaviour
{
    [SerializeField] public IntSO healthSO;
    public GameManager gameManager;
    public SoundManager soundManager;

    public void TakeDamage(int damageTaken)
    {
        soundManager.sfxSource.PlayOneShot(soundManager.damageClip);
        healthSO._value -= damageTaken;
        if (healthSO._value <= 0)
        {       
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameManager.isDead=true;
            //Destroy(gameObject);
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
