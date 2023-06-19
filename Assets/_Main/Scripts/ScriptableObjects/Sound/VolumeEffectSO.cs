using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VolumeEffectSO", menuName = "ScriptableObject/Volume Effect", order = 0)]
public class VolumeEffectSO : ScriptableObject
{
    [Range(0f, 1f)]
    public float Volume = 0.5f;
}