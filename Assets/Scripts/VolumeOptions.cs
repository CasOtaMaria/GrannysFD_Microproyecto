using UnityEngine;
using UnityEngine.UI;

public class VolumeOptions : MonoBehaviour
{
    public Slider volumeSlider;
    public SoundManager soundManager;
    public float sliderValue;

    public Image iconMuted; //para el icono de muted

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumenAudio",0.5f); //creo la variable volumenAudio, con playerprefs se quedara guardada
        AudioListener.volume = volumeSlider.value; //volumen del juego = slider
        IsVolumeMuted();
    }
    public void ChangeVolumeSlider(float volumeValue)
    {
        sliderValue = volumeValue;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = volumeSlider.value;
        IsVolumeMuted();
    }
    public void IsVolumeMuted()
    {
        if (sliderValue == 0)
        {
           iconMuted.enabled = true;
        }
        else
        {
           iconMuted.enabled = false;
        }
       
    }
    public void AudioOnClick()
    {
        soundManager.sfxSource.PlayOneShot(soundManager.buttonClip);
    }
}
