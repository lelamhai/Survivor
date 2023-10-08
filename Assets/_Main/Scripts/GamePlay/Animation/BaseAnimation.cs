using UnityEngine;

public abstract class BaseAnimation : BaseMonoBehaviour
{
    [SerializeField] protected Animator _animator;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadAnimator();
    }

    private void LoadAnimator()
    {
        _animator = this.transform.GetComponent<Animator>();
    }
}