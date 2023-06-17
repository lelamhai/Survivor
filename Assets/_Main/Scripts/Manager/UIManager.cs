using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : BaseMonoBehaviour
{
    public void StartHost()
    {
        ServerManager.Instance.StartHost();
        HideMenu();
    }

    public void StartClient()
    {
        ServerManager.Instance.StartClient();
        HideMenu();
    }

    private void HideMenu()
    {
        this.gameObject.SetActive(false);
    }

    protected override void SetDefaultValue()
    {
    }
}
