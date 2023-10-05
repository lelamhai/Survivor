using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : BaseMonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(TaskOnClick);
    }

    protected abstract void TaskOnClick();

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadButton();
    }

    private void LoadButton()
    {
        _button = this.transform.GetComponent<Button>();
    }
}