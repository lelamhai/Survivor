using System;
using UnityEditor;
using UnityEngine;

public class SpawnPlayer : SingletonSpawn<SpawnPlayer>
{
    protected override void SetDefaultValue()
    {
        base.SetDefaultValue();
        SetPath();
        LoadDatabase();
    }

    private void SetPath()
    {
        _pathFolder = "Players/Database/New Database Players" + Const.Prefix.ASSETS;
    }

    private void LoadDatabase()
    {
#if UNITY_EDITOR
        _database = (BaseDatabaseSO)AssetDatabase.LoadAssetAtPath(Const.Path.PATH_SCRIPTOBJECT + _pathFolder, typeof(BaseDatabaseSO));
#endif
    }
}