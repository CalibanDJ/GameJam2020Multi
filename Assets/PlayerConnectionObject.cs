using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class PlayerConnectionObject : NetworkBehaviour
{
    public GameObject PlayerUnitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if(isLocalPlayer == false)
        {
            return;
        }
        Debug.Log("PlayerObject::Start My own unit");
        CmdSpawnMyUnit();
    }


    // Update is called once per frame
    void Update()
    {
        if(hasAuthority == false)
        {
            return;
        }
    }

 

    [Command]
    void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(PlayerUnitPrefab);
        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
    }


}
