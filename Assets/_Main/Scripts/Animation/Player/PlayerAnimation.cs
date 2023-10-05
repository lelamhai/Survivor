public class PlayerAnimation : BaseAnimation
{
    private void LateUpdate()
    {
        _animator.SetFloat("Speed", InputManager.Instance._Pos.magnitude);
    }

    protected override void SetDefaultValue()
    {}
}