using UnityEngine;
/// <summary>
/// 
/// Singleton and Play Sound . 
/// Play on short audio
/// </summary>
public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayAudio(AudioClip audioClip)
    {
        if (audioClip == null) return;
        m_AudioSource.PlayOneShot(audioClip);
    }


}

