using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador cambia de nivel");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
