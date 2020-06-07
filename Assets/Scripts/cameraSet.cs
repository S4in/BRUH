using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSet : NetworkBehaviour
{
    void Start()
    {
        GameObject playerCamera = new GameObject("playerCamera");
        playerCamera.transform.position = new Vector3(0, 0, -10);
        playerCamera.AddComponent<camera_movement>();

        playerCamera.AddComponent<Camera>();
        playerCamera.GetComponent<Camera>().orthographic = true;

        playerCamera.GetComponent<Camera>().GetComponent<camera_movement>().player = gameObject;
        playerCamera.GetComponent<Camera>().GetComponent<camera_movement>().smoothTimeX = 0.3f;
        playerCamera.GetComponent<Camera>().GetComponent<camera_movement>().smoothTimeY = 0.3f;

        if (isLocalPlayer) return;
        playerCamera.GetComponent<Camera>().enabled = false;
    }
}