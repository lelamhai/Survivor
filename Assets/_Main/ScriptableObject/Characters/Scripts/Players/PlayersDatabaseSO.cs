using UnityEngine;

[CreateAssetMenu(fileName = "New Database Player", menuName = "Survivors/Character/Database/Player/DatabasePlayers")]
public class PlayersDatabaseSO : BaseDatabaseSO
{
    protected override void SetDefaultValue()
    {
        _pathFolder = "Characters/Players/";
    }
}