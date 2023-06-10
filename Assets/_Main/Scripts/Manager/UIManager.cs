using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        HideMenu();
    }

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        HideMenu();
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        HideMenu();
    }

    private void HideMenu()
    {
        this.gameObject.SetActive(false);
    }
}
