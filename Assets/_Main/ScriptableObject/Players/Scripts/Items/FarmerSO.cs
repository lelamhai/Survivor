using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Farmer", menuName = "Survivors/Items/Player")]
public class FarmerSO : BasePlayerSO
{
    protected override void SetInfo()
    {
        _BaseAttributeSO.name = "Le Lam Hai";
        _BaseAttributeSO.description = "This is male";
    }

    protected override void SetPrefab()
    {
        //_Prefab = (Transform)AssetDatabase.LoadAssetAtPath("Assets/_Main/Prefabs/Characters/Players/Farmer_0.prefab", typeof(Transform));
    }
}