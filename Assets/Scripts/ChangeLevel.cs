using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public string scenename;
    private void OnTriggerEnter(Collider collider)
    {   
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("El jugador cambia de nivel");
            SceneManager.LoadScene(scenename);
        }      
    }
}
