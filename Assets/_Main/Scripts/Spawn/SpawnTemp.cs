using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class SpawnTemp : NetworkBehaviour
{
    [SerializeField] private Transform _prefab = null;

    public void Spawn()
    {
        if (!IsOwner) return;
        Transform go = Instantiate(_prefab, this.transform.position, Quaternion.identity);
        go.GetComponent<NetworkObject>().Spawn();
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Spawn();
    }
}
