using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimation : BaseNetworkBehaviour
{
    [SerializeField] private Animator _animator = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;
    [SerializeField] private NetworkVariable<Vector2> _networkPlayerPosition = new NetworkVariable<Vector2>();

    private void LateUpdate()
    {
        if (IsClient && IsOwner)
        {
            ClientInput();
        }

        SetAnimation();
    }

    private void ClientInput()
    {
        UpdatePlayerStateServerRpc(InputManager.Instance._MovePos);
    }

    private void SetAnimation()
    {
        _animator.SetFloat("Speed", _networkPlayerPosition.Value.magnitude);
    }

    [ServerRpc]
    private void UpdatePlayerStateServerRpc(Vector2 pos)
    {
        _networkPlayerPosition.Value = pos;
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _animator = this.GetComponent<Animator>();
    }
}
