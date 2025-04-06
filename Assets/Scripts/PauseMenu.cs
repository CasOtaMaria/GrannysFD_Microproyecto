using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPausaUI;
    public SoundManager soundManager;
    public GameManager gameManager;
    bool pausa = false;

    

    void Start()
    {       
        menuPausaUI.SetActive(false);
       
    }
    public void PauseGame()
    {
        Debug.Log("Se ha pausado el juego");

        menuPausaUI.SetActive(true);       
        pausa = true;
        Time.timeScale = 0f;           
    }
    public void ResumeGame()
    {
        Debug.Log("Se ha reanudado el juego");

        menuPausaUI.SetActive(false);
        pausa = false;
        Time.timeScale = 1f;     
    }

    public void RestartGame() // durante la partida
    {
        Time.timeScale = 1f;
        Debug.Log("Se ha reiniciado el juego");
        SceneManager.LoadScene("Level1");
        gameManager.ResetDataSO();       
    }
    public void RetryGame() // despues de morir
    {
        Debug.Log("Se ha reiniciado el juego");
        SceneManager.LoadScene("Level1");
        gameManager.ResetDataSO();
    }
    public void MainMenu()
    {
        gameManager.ResetDataSO();
        Debug.Log("Se ha vuelto al menu principal");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void AudioOnClick()
    {
        soundManager.sfxSource.PlayOneShot(soundManager.buttonClip);
    }

    
}
