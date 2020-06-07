using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public GameObject pickedPlayer;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
