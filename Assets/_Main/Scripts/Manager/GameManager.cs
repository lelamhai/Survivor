using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Start()
    {
        SpawnEnemy.Instance.SpawnGameObject("Enemy", Vector3.one);
        SpawnZombie.Instance.SpawnGameObject("Zombie", Vector3.one);
    }
}
