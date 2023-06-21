using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : BaseNetworkBehaviour
{
    public void StartHost()
    {
        //ServerManager.Instance.StartHost();

        RelayManager.Instance.StartCoroutine(RelayManager.Instance.ConfigureTransportAndStartNgoAsHost());
        HideMenu();
    }

    public void StartClient()
    {
        //ServerManager.Instance.StartClient();

        RelayManager.Instance.StartCoroutine(RelayManager.Instance.ConfigureTransportAndStartNgoAsConnectingPlayer());
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
