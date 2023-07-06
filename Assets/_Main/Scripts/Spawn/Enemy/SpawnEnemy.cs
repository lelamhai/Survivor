using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeEnemy
{
    Enemy,
    Zombie,
    Player
}

public class SpawnEnemy : SingletonSpawn<SpawnEnemy>
{
    protected override void SetDefaultValue()
    {}
}
