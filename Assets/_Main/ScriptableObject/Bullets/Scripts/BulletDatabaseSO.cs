using UnityEngine;

[CreateAssetMenu(fileName = "New Database Bullets", menuName = "Survivors/Database/Bullets/DatabaseBullets")]
public class BulletDatabaseSO : BaseDatabaseSO
{
    protected override void SetDefaultValue()
    {
        _pathFolder = "Bullets/";
    }
}