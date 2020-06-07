using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class RoundsController : NetworkBehaviour
{
    public GameObject textPrefab;

    public GameObject tileA;
    public GameObject tileB;
    public GameObject tileC;
    public GameObject tileD;

    private void Start()
    {
        if (isServer) return;
        gameObject.SetActive(false);
        /*
        textPrefab.GetComponent<TextMeshPro>().text = "niemiecki polityk pochodzenia austriackiego, kanclerz Rzeszy od 30 stycznia 1933, Wodz i kanclerz Rzeszy (niem. Der Fuhrer und Reichskanzler) od 2 sierpnia 1934 do smierci";
        GameObject answerA = Instantiate(textPrefab);
        answerA.transform.SetParent(tileA.transform);
        answerA.transform.localPosition = new Vector3(0, 0, 0);

        textPrefab.GetComponent<TextMeshPro>().text = "chuj dupa cyce 2";
        GameObject answerB = Instantiate(textPrefab);
        answerB.transform.SetParent(tileB.transform);
        answerB.transform.localPosition = new Vector3(0, 0, 0);
        */
    }

    public void setCurData()
    {
        GameObject question = Instantiate(textPrefab);
        GameObject ansA = Instantiate(tileA);
        GameObject ansB = Instantiate(tileB);
        GameObject ansC = Instantiate(tileC);
        GameObject ansD = Instantiate(tileD);
        NetworkServer.Spawn(question);
        NetworkServer.Spawn(ansA);
        NetworkServer.Spawn(ansB);
        NetworkServer.Spawn(ansC);
        NetworkServer.Spawn(ansD);
    }

    public void clearCurData()
    {
        GameObject[] ansTiles = GameObject.FindGameObjectsWithTag("ansTile");

        foreach (GameObject ansTile in ansTiles)
        {
            NetworkServer.Destroy(ansTile);
        }
        NetworkServer.Destroy(GameObject.FindGameObjectWithTag("question"));
    }
}