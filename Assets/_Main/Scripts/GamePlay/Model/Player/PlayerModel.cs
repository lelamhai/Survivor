using Unity.Netcode;
using UnityEngine;

public class PlayerModel : BaseModel
{
    private NetworkVariable<Vector2> net_Position = new NetworkVariable<Vector2>();

    private void LateUpdate()
    {
        ClientInput();
        FlipPlayer();
    }

    private void ClientInput()
    {
        UpdatePositionServerRpc(InputManager.Instance._Pos);
    }

    [ServerRpc]
    private void UpdatePositionServerRpc(Vector2 pos)
    {
        net_Position.Value = pos;
    }

    private void FlipPlayer()
    {
        if (net_Position.Value.x != 0)
        {
            _spriteRenderer.flipX = net_Position.Value.x < 0;
        }
    }

    protected override void SetDefaultValue()
    { }
}