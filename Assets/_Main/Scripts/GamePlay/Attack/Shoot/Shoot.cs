using Unity.Netcode;

public class Shoot : BaseAttack
{
    //private void Update()
    //{
    //    if (!IsOwner) return;

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        FireBulletServerRpc();
    //    }
    //}

    private void OnEnable()
    {
        InputManager.Instance._Shoot += FireBullet;
    }

    private void OnDisable()
    {
        InputManager.Instance._Shoot -= FireBullet;
    }

    private void FireBullet()
    {
        if (!IsOwner) return;
        FireBulletServerRpc();
    }

    [ServerRpc]
    private void FireBulletServerRpc()
    {
        AttackBullet();
    }

    protected override void SetDefaultValue()
    {}

    protected override void AttackBullet()
    {
        SpawnBullet.Instance.Spawn(0, _point);
    }
}