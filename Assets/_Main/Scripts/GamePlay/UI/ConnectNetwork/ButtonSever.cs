using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ButtonSever : BaseButton
{
    protected override void OnClickButton()
    {
        NetworkManager.Singleton.StartServer();
    }
}