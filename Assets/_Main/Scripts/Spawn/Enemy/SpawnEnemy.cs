using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class SpawnEnemy : SingletonSpawn<SpawnEnemy>
{
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Spawn();
    }

    private void Spawn()
    {
        if (!IsServer) return;
        //var list = SpawnEnemy.Instance.GetPointsGameObject();
        SpawnEnemy.Instance.SpawnGameObject("Enemy", new Vector3(0, 4, 0));
    }

    protected override void SetDefaultValue()
    {
    }
}
