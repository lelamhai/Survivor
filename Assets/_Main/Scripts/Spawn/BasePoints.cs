using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePoints : BaseMonoBehaviour
{
    [SerializeField] private List<Transform> _listPoints = new List<Transform>();

    public List<Transform> GetPoints()
    {
        return _listPoints;
    }


    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        Transform parent = this.transform;
        foreach (Transform item in parent)
        {
            _listPoints.Add(item);
        }
    }
}
