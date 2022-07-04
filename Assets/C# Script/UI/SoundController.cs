using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private Scrollbar _bar;
    public void SoundVolumeChange()
    {
        SoundCreator.SettingVolume = _bar.value;
    }
}
