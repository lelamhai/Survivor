using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerColor : BaseMonoBehaviour
{
    [SerializeField] private SpriteRenderer[] _spriteRenderers;

    private void OnEnable()
    {
        GameManager.Instance._StartGame += StartGame;
    }

    private void OnDisable()
    {
        GameManager.Instance._StartGame -= StartGame;
    }

    private void StartGame()
    {
        if (!IsServer && IsOwner)
        {
            SetColorServerRpc(Color.red);
        }
    }

    [ServerRpc]
    private void SetColorServerRpc(Color color)
    {
        SetColorClientRpc(color);
    }

    [ClientRpc]
    private void SetColorClientRpc(Color color)
    {
        foreach (var item in _spriteRenderers)
        {
            item.color = color;
        }
    }

    protected override void SetDefaultValue()
    {}
}