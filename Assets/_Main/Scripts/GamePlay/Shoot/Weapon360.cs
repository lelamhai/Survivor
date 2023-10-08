using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon360 : BaseMonoBehaviour
{
    [SerializeField] private List<Transform> _listWepon = new List<Transform>();

    private int _bulletAmount = 0;

    private void Start()
    {
        _bulletAmount = _listWepon.Count;
        SpawnBullet();
    }

    private void Update()
    {
        this.transform.RotateAround(this.transform.position, Vector3.back, 20 * Time.deltaTime);
    }

    protected void SpawnBullet()
    {
        float angleStep = 360 / _bulletAmount;
        float _angle = 90;

        for (int i = 0; i < _bulletAmount; i++)
        {
            float bulletDirX = this.transform.position.x + Mathf.Sin((_angle * Mathf.PI) / 180);
            float bulletDirY = this.transform.position.y + Mathf.Cos((_angle * Mathf.PI) / 180);

            Vector3 bulletMoveVector = new Vector3(bulletDirX, bulletDirY, 0);
            Vector2 buletDir = (bulletMoveVector - this.transform.position).normalized;

            float angle = Mathf.Atan2(buletDir.y, buletDir.x) * Mathf.Rad2Deg;
            _listWepon[i].rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            _listWepon[i].Translate(_listWepon[i].up * 1.5f, Space.World);

            _angle += angleStep;
        }
    }


    protected override void SetDefaultValue()
    {}
}