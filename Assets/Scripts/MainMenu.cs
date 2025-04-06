using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameManager gameManager;
    public SoundManager soundManager;

    private void Start()
    {     
        gameManager.ResetDataSO();
    }
    public void Play()
    {
        SceneManager.LoadScene("Level1");        
    }

    public void Exit()
    {
        gameManager.ResetDataSO();
        Application.Quit();
    }
    public void AudioOnClick()
    {
        soundManager.sfxSource.PlayOneShot(soundManager.buttonClip);
    }
}
