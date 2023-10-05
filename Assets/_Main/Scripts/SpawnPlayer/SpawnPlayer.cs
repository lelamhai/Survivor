using UnityEditor;
using UnityEngine;

public class SpawnPlayer : SingletonSpawn<SpawnPlayer>
{
    [Header("SpawnPlayer")]
    [SerializeField] private string _pathFolder = "Characters/DatabasePlayers"+Const.Prefix.ASSETS;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadDatabase();
    }

    private void LoadDatabase()
    {
        _database = (BaseDatabaseSO)AssetDatabase.LoadAssetAtPath(Const.Path.PATH_SCRIPTOBJECT+ _pathFolder, typeof(BaseDatabaseSO));
    }

    protected override void SetDefaultValue()
    {}
}