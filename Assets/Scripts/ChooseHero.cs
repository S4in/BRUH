using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class ChooseHero : NetworkBehaviour
{ 
    public static int number;
    public List<GameObject> players;
    public GameObject curPlayer;

    void Start()
    {
        number = 0;
        curPlayer = Instantiate(players[number]);
    }

    public void LeftClick()
    {
        Destroy(curPlayer);
        Debug.Log("clicked on left");
        number = number - 1; //zmniejszamy index aktualnej postaci ( przesuwamy ją w lewo )
        if (number < 0)
            number = players.Count - 1;
        curPlayer = Instantiate(players[number]);
    }
    public void RightClick()
    {
        Destroy(curPlayer);
        Debug.Log("clicked on right");
        number = number + 1; //zwiekszamy index aktualnej postaci ( przesuwamy ją w prawo )
        if (number > players.Count - 1)
            number = 0;
        curPlayer = Instantiate(players[number]);
    }
    public void Zatwierdz()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //przejscie do kolejnej sceny
        curPlayer = players[number];
        GameObject networkManager = GameObject.Find("Networking");
        //networkManager.GetComponent<NetworkManager>().playerPrefab = curPlayer.GetComponent<originalPrefab>().prefab;
        if (!NetworkClient.active)
        {
            //GameObject.Find("curPlayer").GetComponent<dontDestroy>().pickedPlayer = curPlayer.GetComponent<originalPrefab>().prefab;
            networkManager.GetComponent<NetworkManager>().StartClient();
            //GameObject player = Instantiate(curPlayer.GetComponent<originalPrefab>().prefab);
            //NetworkServer.Spawn(player);
        }
        networkManager.GetComponent<NetworkManager>().networkAddress = "localhost";
    }
}