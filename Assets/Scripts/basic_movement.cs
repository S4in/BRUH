using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class basic_movement : NetworkBehaviour
{

    private float speed = 5f;
    public bool facingEast;

    void Start()
    {
        facingEast = true;

        if (isLocalPlayer) return;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void Update()
    {
        if (!hasAuthority)
        {
            return;
        }
        turn();
    }
    void FixedUpdate()
    {
        if (!hasAuthority)
        {
            return;
        }
        move();
    }

    private void move()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        transform.position = transform.position +
            new Vector3(moveH * speed * Time.deltaTime, moveV * speed * Time.deltaTime, 0);
    }

    private void turn()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (facingEast == false)
            {
                facingEast = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (facingEast == true)
            {
                facingEast = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
}