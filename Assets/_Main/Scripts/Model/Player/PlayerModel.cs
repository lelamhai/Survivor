public class PlayerModel : BaseModel
{
    private void LateUpdate()
    {
        if(InputManager.Instance._Pos.x != 0)
        {
            _spriteRenderer.flipX = InputManager.Instance._Pos.x < 0;
        }
    }

    protected override void SetDefaultValue()
    {}
}