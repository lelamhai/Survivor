using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    [Header("Load level in GamePlay")]
    [SerializeField] private Transform parent;

    [Header("All level in Game")]
    [SerializeField] private int _level = 0;
    [SerializeField] private List<Transform> _listAllLevel = new List<Transform>();

    private Transform _currentLevel = null;

    private void OnEnable()
    {
        GameManager.Instance._StartGame += LoadLevel;
    }

    private void OnDisable()
    {
        GameManager.Instance._StartGame -= LoadLevel;
    }

    private void LoadLevel()
    {
        if (_listAllLevel.Count <= 0)
        {
            Debug.LogError("List level empty");
            return;
        }

        if (_currentLevel != null)
        {
            Destroy(_currentLevel.gameObject);
        }

        _currentLevel = Instantiate(_listAllLevel[_level], parent);
        _currentLevel.transform.SetParent(parent);
    }

    protected override void SetDefaultValue()
    {}
}
