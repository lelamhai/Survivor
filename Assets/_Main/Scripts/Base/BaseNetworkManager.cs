using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class BaseNetworkManager : NetworkBehaviour
{
    [SerializeField] private Transform _prefab;
    private int connectPlayer = 0;
    

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        NetworkManager.OnServerStarted += NetStartServer;
    }

    private void NetStartServer()
    {
        if (!IsServer) return;

        connectPlayer++;
        NetworkManager.Singleton.OnClientConnectedCallback += NetOnClientConnectedCallback;
    }

    private void NetOnClientConnectedCallback(ulong obj)
    {
        connectPlayer++;
        if(connectPlayer >= 2)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        if (!IsOwner) return;
        Transform go = Instantiate(_prefab, this.transform.position, Quaternion.identity);
        go.GetComponent<NetworkObject>().Spawn();
    }
}
