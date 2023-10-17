using Unity.Netcode;

public abstract class BaseMonoBehaviour : NetworkBehaviour
{
    private void Reset()
    {
        SetDefaultValue();
    }

    protected abstract void SetDefaultValue();
}
