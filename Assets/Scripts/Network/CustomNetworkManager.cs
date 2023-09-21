using Mirror;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("Client starting...");
    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("Server starting...");
    }

    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log("Host starting...");
    }
}
