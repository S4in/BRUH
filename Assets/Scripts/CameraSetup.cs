using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetup : NetworkBehaviour
{
    public GameObject cameraPrefab;
    void Start()
    {
        GameObject playerCamera = new GameObject();
        playerCamera = Instantiate(cameraPrefab);
        playerCamera.GetComponent<camera_movement>().player = gameObject;

        if (isLocalPlayer) return;
        playerCamera.GetComponent<Camera>().enabled = false;
        playerCamera.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }
}