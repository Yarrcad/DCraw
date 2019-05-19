using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BadGuy")
        {
            player.SetActive(false);
        }
    }


}
