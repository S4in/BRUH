using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Detect : NetworkBehaviour
{
    public string curTile;

    private void Start()
    {
        curTile = null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("A_tile"))
        {
            curTile = "A";
            Debug.Log("curTile: " + curTile);
        }
        if (collision.tag.Equals("B_tile"))
        {
            curTile = "B";
            Debug.Log("curTile: " + curTile);
        }
        if (collision.tag.Equals("C_tile"))
        {
            curTile = "C";
            Debug.Log("curTile: " + curTile);
        }
        if (collision.tag.Equals("D_tile"))
        {
            curTile = "D";
            Debug.Log("curTile: " + curTile);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("A_tile") || collision.tag.Equals("B_tile") || collision.tag.Equals("C_tile") || collision.tag.Equals("D_tile"))
        {
            curTile = null;
            Debug.Log("curTile: " + curTile);
        }
    }
}