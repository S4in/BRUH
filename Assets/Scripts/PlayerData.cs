using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string id;
    public int pytaniaAll;
    public int odpGood;
    public int odpBad;
    public float timeAll;
    public float timeAttention;
    public float timeNoAttention;

    private void Start()
    {
        //id = GameObject.Find("UserData").GetComponent<UserData>().id;
        id = gameObject.GetComponent<NetworkIdentity>().netId.ToString();
    }
}
