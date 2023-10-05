using UnityEngine;

public abstract class BaseMonoBehaviour : MonoBehaviour
{
    private void Reset()
    {
        SetDefaultValue();
        LoadComponent();
    }

    protected virtual void LoadComponent()
    {

    }

    protected abstract void SetDefaultValue();
}
