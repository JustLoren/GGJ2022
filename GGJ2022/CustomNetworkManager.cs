using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomNetworkManager : NetworkManager  
{
   public void StartHosting()
    {

        base.StartHost();
    }


}
