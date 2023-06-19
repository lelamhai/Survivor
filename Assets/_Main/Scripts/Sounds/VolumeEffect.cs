using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeEffect : Singleton<VolumeEffect>
{
    [SerializeField] private AudioSource _audioSourceEffect = null;
    [SerializeField] private VolumeEffectSO _soundVolume = null;

    private void Start()
    {
        SetVolume();
    }

    private void SetVolume()
    {
        _audioSourceEffect.volume = _soundVolume.Volume;
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        LoadAudioSource();
        LoadScriptableObject();
    }

    private void LoadAudioSource()
    {
        _audioSourceEffect = this.GetComponent<AudioSource>();
    }

    private void LoadScriptableObject()
    {
        string path = "ScriptableObjects/Sound/" + this.name + "SO";
        

        this._soundVolume = Resources.Load<VolumeEffectSO>(path);
    }
}
