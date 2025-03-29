using UnityEngine;

public class AudioManger : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clips")]
    [SerializeField] AudioClip background;
    [SerializeField] AudioClip SFX0;
    [SerializeField] AudioClip SFX1;

    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    
    void Update()
    {
        
    }

    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
}
