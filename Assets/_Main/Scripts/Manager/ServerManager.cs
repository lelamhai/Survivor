using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Unity.Netcode;
using TMPro;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class ServerManager : Singleton<ServerManager>
{
    [SerializeField] private TMP_Text _joinCode = null;

    private void Start()
    {
        _joinCode.text = GetLocalIPv4();
        UnityTransport utp = NetworkManager.Singleton.GetComponent<UnityTransport>();
        utp.SetConnectionData(GetLocalIPv4(), 7777);
    }

    public override void OnNetworkSpawn()
    {
        Debug.Log("OnNetworkSpawn");
    }

    private string GetLocalIPv4()
    {
        return Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(f => f.AddressFamily == AddressFamily.InterNetwork).ToString();
    }

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
    }

    public void StartClient()
    {
        string ipAddress = GetLocalIPv4();
        UnityTransport utp = NetworkManager.Singleton.GetComponent<UnityTransport>();
        utp.SetConnectionData(ipAddress, 7777);


        NetworkManager.Singleton.StartClient();
    }

    protected override void SetDefaultValue()
    {}
}
