using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomData : MonoBehaviour
{
    public List<List<string>> data = new List<List<string>>();

    private void Start()
    {
        List<string> tmp = new List<string>();
        tmp.Add("czy hitler byl dobrym czlowiekiem");
        data.Add(tmp);
    }
}
