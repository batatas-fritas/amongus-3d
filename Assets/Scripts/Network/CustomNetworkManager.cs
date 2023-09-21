using Mirror;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("Client starting...");
    }
}
