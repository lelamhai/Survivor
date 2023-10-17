using UnityEngine;

public abstract class BaseAnimation : BaseMonoBehaviour
{
    [SerializeField] protected Animator _animator;

    protected override void SetDefaultValue()
    {
        LoadAnimator();
    }

    private void LoadAnimator()
    {
        _animator = this.transform.GetComponent<Animator>();
    }
}