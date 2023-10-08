using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum NamePanel
{
    ConnectNetwork,
    Waiting
}

public enum StatePanel
{
    Show,
    Hide
}

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private List<GameObject> _listPanel = new List<GameObject>();
    [SerializeField] private NamePanel _currentUIState = NamePanel.ConnectNetwork;

    private void Start()
    {
        SetPanelState(_currentUIState, StatePanel.Show);
    }

    private void OnEnable()
    {
        GameManager.Instance._StartGame += StartGame;
    }

    private void OnDisable()
    {
        GameManager.Instance._StartGame -= StartGame;
    }

    private void StartGame()
    {
        _currentUIState = NamePanel.Waiting;
        SetPanelState(NamePanel.Waiting, StatePanel.Hide);
    }

    public void SetPanelState(NamePanel namePanel, StatePanel statePanel)
    {
        _currentUIState = namePanel;
        switch (statePanel)
        {
            case StatePanel.Show:
                ShowPanel();
                break;

            case StatePanel.Hide:
                HidePanel();
                break;

            default:
                break;
        }
    }

    private void ShowPanel()
    {
        GameObject panel = _listPanel.Where(obj => obj.name == _currentUIState.ToString()).SingleOrDefault();
        if (panel == null) return;
        panel.SetActive(true);
    }

    private void HidePanel()
    {
        GameObject panel = _listPanel.Where(obj => obj.name == _currentUIState.ToString()).SingleOrDefault();
        if (panel == null) return;
        panel.SetActive(false);
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadAllPanelUI();
    }

    private void LoadAllPanelUI()
    {
        Transform parent = this.transform;
        foreach (Transform item in parent)
        {
            item.gameObject.SetActive(false);
            _listPanel.Add(item.gameObject);
        }
    }
}
