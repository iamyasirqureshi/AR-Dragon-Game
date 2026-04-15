using UnityEngine;

public class DragonAudioStart : MonoBehaviour
{
    void OnEnable()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
    }
}
