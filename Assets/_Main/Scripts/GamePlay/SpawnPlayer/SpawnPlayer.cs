using UnityEditor;
using UnityEngine;

public class SpawnPlayer : SingletonSpawn<SpawnPlayer>
{
    [Header("SpawnPlayer")]
    [SerializeField] private string _pathFolder = "Characters/DatabasePlayers"+Const.Prefix.ASSETS;

    //private void Start()
    //{
    //    Spawn(0);
    //}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadDatabase();
    }

    private void LoadDatabase()
    {
#if UNITY_EDITOR
        _database = (BaseDatabaseSO)AssetDatabase.LoadAssetAtPath(Const.Path.PATH_SCRIPTOBJECT + _pathFolder, typeof(BaseDatabaseSO));
#endif
    }

    protected override void SetDefaultValue()
    {}
}