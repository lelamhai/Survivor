using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFollowTarget : MonoBehaviour
{
    [SerializeField] private Vector3 _pointBegin = Vector3.zero;
    [SerializeField] private Transform _target = null;

    private void OnEnable()
    {
        _pointBegin = this.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision: " + collision.gameObject.name);
        _target = collision.transform;
        EnemyMove move = this.GetComponent<EnemyMove>();
        move.SetFollowPlayer(_target, true);
    }
}
