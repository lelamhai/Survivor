using UnityEngine;

public abstract class BaseModel : BaseMonoBehaviour
{
    [SerializeField] protected SpriteRenderer _spriteRenderer;

    protected override void SetDefaultValue()
    {
        LoadSprite();
    }

    private void LoadSprite()
    {
        _spriteRenderer = this.GetComponent<SpriteRenderer>();
    }
}