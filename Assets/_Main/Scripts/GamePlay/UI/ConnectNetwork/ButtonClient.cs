using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ButtonClient : BaseButton
{
    protected override void OnClickButton()
    {
        RelayManager.Instance.StartCoroutine(RelayManager.Instance.ConfigureTransportAndStartNgoAsConnectingPlayer());
        UIManager.Instance.SetPanelState(NamePanel.ConnectNetwork, StatePanel.Hide);
        UIManager.Instance.SetPanelState(NamePanel.Waiting, StatePanel.Show);
    }
}
