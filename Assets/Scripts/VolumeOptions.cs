using UnityEngine;
using UnityEngine.UI;

public class VolumeOptions : MonoBehaviour
{
    public Slider volumeSlider;
    public float sliderValue;

   // public Image iconMuted; //para el icono de muted

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumenAudio",0.5f); //creo la variable volumenAudio, con playerprefs se quedara guardada
        AudioListener.volume = volumeSlider.value; //volumen del juego = slider
        IsMuted();
    }
    public void ChangeSlider(float volumeValue)
    {
        sliderValue = volumeValue;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = volumeSlider.value;
        IsMuted();
    }
    public void IsMuted()
    {
        if (sliderValue == 0)
        {
           // iconMuted.enabled = true;
        }
        else
        {
           // iconMuted.enabled = false;
        }
       
    }
}
