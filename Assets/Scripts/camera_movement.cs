using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    public GameObject player;

    public float smoothTimeX;
    public float smoothTimeY;

    private Vector2 velocity;

    public Vector3 minPos;
    public Vector3 maxPos;

    public bool isBounded;

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);

        if (isBounded)
        {
            transform.position = new Vector3
                (
                    Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
                    Mathf.Clamp(transform.position.y, minPos.y, maxPos.y),
                    Mathf.Clamp(transform.position.z, minPos.z, maxPos.z)
                );
        }
    }
}
