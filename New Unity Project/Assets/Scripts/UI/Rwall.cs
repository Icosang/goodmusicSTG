﻿using UnityEngine;

public class Rwall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c)

    {
        if (c.gameObject.tag == "Player")
        {
            PlayerScript player = c.gameObject?.GetComponent<PlayerScript>();
            if (player != null){
                player.RMoveSwitch = false;
                player.inputX = 0f;
            }
        }
    }
    void OnCollisionExit2D(Collision2D c)

    {
        if (c.gameObject.tag == "Player")
        {
            PlayerScript player = c.gameObject?.GetComponent<PlayerScript>();
            if (player != null) player.RMoveSwitch = true;
        }
    }
}
