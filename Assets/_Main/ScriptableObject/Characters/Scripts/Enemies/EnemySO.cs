using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New enemy", menuName = "Survivors/Character/ScriptableObject/Enemy")]
public class EnemySO : BaseGameObjectSO
{
    protected override void SetInfo()
    {
        
    }

    protected override void SetPrefab()
    {
        //_Prefab = (Transform)AssetDatabase.LoadAssetAtPath("Assets/_Main/Prefabs/Characters/Enemies/GreenEnemy.prefab", typeof(Transform));
    }
}
