using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0 : BaseMonoBehaviour
{
    [SerializeField] private List<LevelData> _listLevelData = new List<LevelData>();
    [SerializeField] private int _currentIndexWave = 0;
    [SerializeField] private float _timer = 1;

    private LevelData _currentWave;
    private void Awake()
    {
        GameManager.Instance.SetStage(GameStates.SetupLevel);
    }

    private void Start()
    {
        if(_listLevelData.Count > 0)
        {
            StartCoroutine(SpawnData());
        } else
        {
            Debug.Log("List Level empty", this);
        }
    }

    private IEnumerator SpawnData()
    {
        _currentWave = _listLevelData[_currentIndexWave];
        if(_currentWave._duration > 0)
        {
            for (int i = 0; i < _currentWave._wave.Count; i++)
            {
                StartCoroutine(SpawnWave(_currentWave._wave[i], _currentWave._duration));
            }

            yield return new WaitForSeconds(_currentWave._duration);
            _currentIndexWave++;

            if (_currentIndexWave < _listLevelData.Count)
            {
                StartCoroutine(SpawnData());
            }
           
        } else
        {
            Debug.Log("The wave is duration 0", this);
            yield return null;
        }
       
    }

    private IEnumerator SpawnWave(WaveData wave, float duration)
    {
        yield return new WaitForSeconds(wave._delay);
        _timer += wave._delay;
        for (int i = 1; i <= wave._numberEnemy; i++)
        {
            SpawnEnemy.Instance.SpawnGameObject(wave._typeEnemy.ToString(), SpawnEnemy.Instance.GetPoint());
        }

        if (_timer < duration)
        {
            StartCoroutine(SpawnWave(wave, duration));
        }
    }

    protected override void SetDefaultValue()
    {}
}

[System.Serializable]
struct LevelData
{
    public List<WaveData> _wave;
    public float _duration;
}

[System.Serializable]
struct WaveData
{
    public TypeEnemy _typeEnemy;
    public float _delay;
    public int _numberEnemy;
}
