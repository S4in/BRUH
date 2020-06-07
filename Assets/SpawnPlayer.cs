using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : NetworkBehaviour
{
    void Start()
    {
        GameObject player = Instantiate(GameObject.Find("curPlayer").GetComponent<dontDestroy>().pickedPlayer);
        NetworkServer.Spawn(player);
    }
}
