using UnityEngine;

[CreateAssetMenu(fileName = "New Database Enemies", menuName = "Survivors/Character/Database/Enemy/DatabaseEnemies")]
public class EnemiesDatabaseSO : BaseDatabaseSO
{
    protected override void SetDefaultValue()
    {
        _pathFolder = "Characters/Enemies/";
    }
}