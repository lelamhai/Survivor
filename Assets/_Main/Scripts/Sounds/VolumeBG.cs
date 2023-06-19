using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeBG : BaseMonoBehaviour
{
    [SerializeField] private AudioSource _audioSourceBG = null;
    [SerializeField] private VolumeBGSO _soundVolume = null;
    [SerializeField] private List<AudioClip> _listBGSound = new List<AudioClip>();

    private void Start()
    {
        SetVolume();
        PlaySoundBG();
    }

    private void SetVolume()
    {
        _audioSourceBG.volume = _soundVolume.Volume;
    }

    public void PlaySoundBG()
    {
        _audioSourceBG.PlayOneShot(_listBGSound[0]);
    }

    protected override void SetDefaultValue()
    {

    }

    protected override void LoadComponent()
    {
        LoadScriptableObject();
        LoadAudioSource();
    }

    private void LoadAudioSource()
    {
        _audioSourceBG = this.GetComponent<AudioSource>();
    }

    private void LoadScriptableObject()
    {
        string path = "ScriptableObjects/Sound/" + this.name + "SO";
        this._soundVolume = Resources.Load<VolumeBGSO>(path);
    }
}
