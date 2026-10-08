using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [SerializeField] private AudioClip gameplay;
    [SerializeField] private AudioClip death;
    [SerializeField] private AudioClip menu;

    private void Start()
    {
        musicSource.clip = gameplay;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlayDeath()
    {
        SFXSource.PlayOneShot(death);
    }

}
