using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : BaseMonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform _joystick = null;
    [SerializeField] private RectTransform _innerCircle = null;
    private Vector3 _pos = Vector3.zero;

    public void OnDrag(PointerEventData eventData)
    {
        CalculateInnerCirclePosition(eventData.position);
        CalculateInputVector();
        CalculateInnerCircleRotation();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _innerCircle.anchoredPosition = Vector2.zero;
        _innerCircle.localRotation = Quaternion.identity;
        _pos = Vector2.zero;
    }

    private void CalculateInnerCirclePosition(Vector2 position)
    {
        Vector2 directPosition = position - (Vector2)_joystick.position;
        if (directPosition.magnitude > _joystick.rect.width / 2f)
            directPosition = directPosition.normalized * _joystick.rect.width / 2f;
        _innerCircle.anchoredPosition = directPosition;
    }

    private void CalculateInputVector()
    {
        _pos = _innerCircle.anchoredPosition / (_joystick.rect.size / 2f);
    }

    private void CalculateInnerCircleRotation()
    {
        _innerCircle.localRotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, _pos));
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadJoystick();
    }

    private void LoadJoystick()
    {
        _joystick = this.GetComponent<RectTransform>();
        _innerCircle = this.transform.Find("Inner").GetComponent<RectTransform>();
    }
}