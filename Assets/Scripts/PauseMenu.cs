using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPausaUI;
    public GameManager gameManager;
    bool pausa = false;

    void Start()
    {       
        menuPausaUI.SetActive(false);
    }
    void Update()
    {/*
        Debug.Log("se inicia el update de pausa");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("se ha presionado esc");
            if (pausa)
            {
                PauseGame();           
                Debug.Log("se ha pausado");              
            }
            else if (!pausa)
            {
                ResumeGame();
            }
        }*/
        //LO HE COLOCADO EN EL GAME MANAGER
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

    public void RestartGame()
    {
        Debug.Log("Se ha reiniciado el juego");
        gameManager.ResetDataSO();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
        Time.timeScale = 1f;
        //Cuando tenga mas escenas hay que hacer una lista con todas para que se reinicien
    }
    public void MainMenu()
    {
        Debug.Log("Se ha vuelto al menu principal");

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
