using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : SingletonSpawn<SpawnEnemy>
{
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (!IsServer) return;
        //    Spawn(0);
        //}
    }

    protected override void SetDefaultValue()
    {}
}
