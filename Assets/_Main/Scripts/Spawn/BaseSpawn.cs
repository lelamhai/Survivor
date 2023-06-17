using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public abstract class BaseSpawn : BaseMonoBehaviour
{
    [Header("Base Spawn")]
    [SerializeField] protected BasePrefabs _basePrefabs = null;
    [SerializeField] protected BaseHolders _baseHolders = null;
    [SerializeField] protected BasePoints _basePoints = null;
    private Transform _currentGameObject = null;

    public void SpawnGameObject(string name, Vector3 point)
    {
        if (_baseHolders.CheckGameObjectPool(name) > 0)
        {
            _currentGameObject = _baseHolders.UndoGameObject(name);
            if (_currentGameObject == null) return;
            SetUndoGameObject(_currentGameObject, name, point);
            RemoveGameObjectPool(_currentGameObject);
        } else
        {
            _currentGameObject = _basePrefabs.CloneGameObject(name);
            if (_currentGameObject == null) return;
            SetUndoGameObject(_currentGameObject, name, point);
        }
        _currentGameObject.GetComponent<NetworkObject>().Spawn();
    }

    private void SetUndoGameObject(Transform gameObject, string name, Vector3 point)
    {
        gameObject.SetPositionAndRotation(point, Quaternion.identity);
        gameObject.gameObject.SetActive(true);
        gameObject.name = name;
        gameObject.SetParent(_baseHolders.transform);
    }

    protected override void LoadComponent()
    {
        Transform prefab = transform.Find("Prefabs");
        _basePrefabs = prefab.GetComponent<BasePrefabs>();

        Transform holder = transform.Find("Holders");
        _baseHolders = holder.GetComponent<BaseHolders>();

        Transform points = transform.Find("Points");
        _basePoints = points.GetComponent<BasePoints>();
    }

    public void AddGameObjectPool(Transform gameobject)
    {
        _baseHolders.AddObjectPool(gameobject);
    }

    public void RemoveGameObjectPool(Transform gameobject)
    {
        _baseHolders.RemoveObjectPool(gameobject);
    }

    public List<Transform> GetPointsGameObject()
    {
        return _basePoints.GetPoints();
    }
}
