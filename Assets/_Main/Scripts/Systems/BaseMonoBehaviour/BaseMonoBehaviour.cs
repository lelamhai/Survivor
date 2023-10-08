using Unity.Netcode;

public abstract class BaseMonoBehaviour : NetworkBehaviour
{
    private void Reset()
    {
        SetDefaultValue();
        LoadComponent();
    }

    protected virtual void LoadComponent()
    {}

    protected abstract void SetDefaultValue();
}
