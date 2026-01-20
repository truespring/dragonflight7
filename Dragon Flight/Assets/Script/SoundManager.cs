using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public static SoundManager instance;
    AudioSource myAudio;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public AudioClip soundBullet;
    public AudioClip soundDie;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
