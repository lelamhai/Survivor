using UnityEditor;
using UnityEngine;

public class SpawnBullet : SingletonSpawn<SpawnBullet>
{
    protected override void SetDefaultValue()
    {
        base.SetDefaultValue();
        SetPath();
        LoadDatabase();
    }

    private void SetPath()
    {
        _pathFolder = "Bullets/Database/New Database Bullets" + Const.Prefix.ASSETS;
    }

    private void LoadDatabase()
    {
#if UNITY_EDITOR
        _database = (BaseDatabaseSO)AssetDatabase.LoadAssetAtPath(Const.Path.PATH_SCRIPTOBJECT + _pathFolder, typeof(BaseDatabaseSO));
#endif
    }
}