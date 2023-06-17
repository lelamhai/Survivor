using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class SpawnEnemy : SingletonSpawn<SpawnEnemy>
{
    private void Start()
    {
        if (!IsServer) return; 

        var list = SpawnEnemy.Instance.GetPointsGameObject();
        for (int i = 0; i < list.Count; i++)
        {
             SpawnEnemy.Instance.SpawnGameObject("Enemy", list[i].position);

        }
    }

    protected override void SetDefaultValue()
    {
    }
}
