using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VolumeBGSO", menuName = "ScriptableObject/Volume BG", order = 0)]
public class VolumeBGSO : ScriptableObject
{
    [Range(0f, 1f)]
    public float Volume = 0.5f;
}
