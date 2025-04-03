using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameManager gameManager;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        gameManager.ResetDataSO();
    }

    public void Exit()
    {
        gameManager.ResetDataSO();
        Application.Quit();
    }
}
