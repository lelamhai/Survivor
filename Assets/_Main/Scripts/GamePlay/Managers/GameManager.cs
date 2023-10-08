using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    public UnityAction _StartGame, _GamePlay, _FinishLevel, _GameOver;
    private int ConnectedPlayers;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        NetworkManager.OnServerStarted += Net_ServerStarted;
    }

    private void Net_ServerStarted()
    {
        if (!IsServer) return;
        ConnectedPlayers++;
        NetworkManager.OnClientConnectedCallback += net_ClientConnectedCallback;
    }

    private void net_ClientConnectedCallback(ulong obj)
    {
        ConnectedPlayers++;
        Debug.Log("ConnectedPlayers: " + ConnectedPlayers);
        if (ConnectedPlayers >= 2)
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        StartGameClientRpc();
    }

    [ClientRpc]
    private void StartGameClientRpc()
    {
        _StartGame?.Invoke();
    }

    protected override void SetDefaultValue()
    {}
}