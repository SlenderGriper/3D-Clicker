using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCreator : MonoBehaviour
{
    [SerializeField] private AudioClip _sound;
    [SerializeField] private GameObject _soundObject;
    [SerializeField] private float volume;
    public void Create()
    {
        var playSound = Instantiate(_soundObject);
        playSound.GetComponent<Audio>().StartAudio(_sound,volume);
    }
}
