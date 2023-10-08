using UnityEngine;

public abstract class BaseSpawn : BaseMonoBehaviour
{
    [Header("Base Spawn")]
    [SerializeField] protected BaseDatabaseSO _database;
    [SerializeField] protected BaseHolders _baseHolders = null;

    public Transform FindDatabaseById(int id)
    {
        if (_database._dictionaryGameObject.ContainsKey(id))
        {
            return _database._dictionaryGameObject[id];
        }
        return null;
    }

    public void Spawn(int id)
    {
        Transform gameObject = _baseHolders.Get(id);
        if (gameObject == null)
        {
            Transform findObject = FindDatabaseById(id);
            if(findObject != null)
            {
                Transform clone = Clone(findObject);
                clone.SetParent(_baseHolders.transform);
            }
        }
    }

    public void Release(int key, Transform value)
    {
        _baseHolders.Release(key, value);
    }

    private Transform Clone(Transform item)
    {
        return Instantiate(item);
    }
   
    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadHolder();
    }

    protected void LoadHolder()
    {
        _baseHolders = transform.Find(Const.Spawn.HOLDERS).GetComponent<BaseHolders>();
    }
}