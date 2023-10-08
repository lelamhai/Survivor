using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAttribute : BaseMonoBehaviour
{
    [SerializeField] private BaseGameObjectSO _attribute;
    public BaseGameObjectSO _Attribute => _attribute;
}
