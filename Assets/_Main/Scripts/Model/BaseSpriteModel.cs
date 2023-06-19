using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public abstract class BaseSpriteModel : BaseNetworkBehaviour
{
    [SerializeField] private SpriteRenderer _model = null;
    [SerializeField] private BaseMove _baseMove = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;
    [SerializeField] private NetworkVariable<Vector2> _networkPlayerPosition= new NetworkVariable<Vector2>();
    private void LateUpdate()
    {
        if (IsClient && IsOwner)
        {
            InputClient();
        }

        SetFlip();
    }

    private void InputClient()
    {
        UpdateClientPositionServerRpc(_baseMove.GetCurrentPos());
    }

    private void SetFlip()
    {
        if (_networkPlayerPosition.Value.x != 0)
        {
            _model.flipX = _networkPlayerPosition.Value.x < 0;
        }
    }

    [ServerRpc]
    public void UpdateClientPositionServerRpc(Vector2 pos)
    {
        _networkPlayerPosition.Value = pos;
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _model = this.GetComponent<SpriteRenderer>();
        _baseMove = this.GetComponent<BaseMove>();
    }
}
