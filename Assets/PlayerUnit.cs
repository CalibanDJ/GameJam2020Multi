﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class PlayerUnit : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasAuthority == false)
        {

            return;
        }
        //CmdMove();

        if(Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(GameObject);
        }
        
    }
}
