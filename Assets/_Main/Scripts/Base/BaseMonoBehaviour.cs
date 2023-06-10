using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public abstract class BaseMonoBehaviour : NetworkBehaviour
{
    private void Reset()
    {
        LoadComponent();
        SetDefaultValue();
    }

    protected virtual void LoadComponent()
    {

    }

    protected abstract void SetDefaultValue();
}
