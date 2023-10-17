using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ButtonHost : BaseButton
{
    protected override void OnClickButton()
    {
        //NetworkManager.Singleton.StartHost();
        RelayManager.Instance.StartCoroutine(RelayManager.Instance.ConfigureTransportAndStartNgoAsHost());
        UIManager.Instance.SetPanelState(NamePanel.ConnectNetwork, StatePanel.Hide);
        UIManager.Instance.SetPanelState(NamePanel.Waiting, StatePanel.Show);
    }
}