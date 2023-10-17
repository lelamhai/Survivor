using System;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimation : BaseAnimation
{
    private NetworkVariable<Vector2> net_Position = new NetworkVariable<Vector2>();

    private void LateUpdate()
    {
        if (IsClient && IsOwner)
        {
            ClientInput();
        } 
        AnimationPlayer();
    }

    private void ClientInput()
    {
        UpdatePositionServerRpc(InputManager.Instance._Pos);
    }

    private void AnimationPlayer()
    {
        _animator.SetFloat("Speed", net_Position.Value.magnitude);
    }

    [ServerRpc]
    private void UpdatePositionServerRpc(Vector2 pos)
    {
        net_Position.Value = pos;
    }

    protected override void SetDefaultValue()
    {}
}