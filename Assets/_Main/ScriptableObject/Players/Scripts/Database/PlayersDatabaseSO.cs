using UnityEngine;

[CreateAssetMenu(fileName = "New Database Players", menuName = "Survivors/Database/Player/DatabasePlayers")]
public class PlayersDatabaseSO : BaseDatabaseSO
{
    protected override void SetDefaultValue()
    {
        _pathFolder = "Players/";
    }
}