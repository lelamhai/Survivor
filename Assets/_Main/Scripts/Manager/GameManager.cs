using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public enum StateGame
{
    None,
    StartGame
}

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private StateGame _currentStateGame = StateGame.None;
    public UnityAction OnStartGame = null;
    public UnityAction OnJointHost = null;
    public UnityAction OnJointClient = null;

    private void JoinHost()
    {
        OnStartGame?.Invoke();
    }

    private void JoinClient()
    {
        OnJointClient?.Invoke();
    }

    private void StartGame()
    {
        OnStartGame?.Invoke();
    }

    protected override void SetDefaultValue()
    {}
}
