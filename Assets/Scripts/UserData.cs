using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public string id;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
