using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("----------SOUND----------")]
    [Header("Audio Source")]
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioSource walkingSource;
    [Header("Audio Clip")]
    public AudioClip backgroundClip;
    public AudioClip coinClip;
    public AudioClip damageClip;
    public AudioClip shootClip;
    public AudioClip buttonClip;

    void Start()
    {
        musicSource.gameObject.AddComponent<AudioSource>();
        sfxSource.gameObject.AddComponent<AudioSource>();

        musicSource.loop = true;
        musicSource.clip = backgroundClip;
        musicSource.Play();
    }

}
