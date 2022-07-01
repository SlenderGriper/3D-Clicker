using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{
    AudioSource _audio;
    public void StartAudio(AudioClip sound,float volume)
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = sound;
        _audio.volume = volume;
        _audio.Play();
        StartCoroutine(PauseAudio());
    }
    IEnumerator PauseAudio()
    {
        yield return new WaitForSeconds(_audio.clip.length);
        Destroy(gameObject);
    }
}