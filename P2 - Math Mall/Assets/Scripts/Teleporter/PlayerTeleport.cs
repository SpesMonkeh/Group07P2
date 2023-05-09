using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
     //private GameObject currentTeleporter;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Teleporter")
        {
            transform.position = new Vector3(10, 25, 0);
        }

        if (collision.gameObject.tag == "Teleporter2")
        {
            transform.position = new Vector3(-30, 57, 0);
        }

        if(collision.gameObject.tag == "Teleporter3")
        {
            transform.position = new Vector3(21, 96, 0);
        }

        if (collision.gameObject.tag == "Teleporter4")
        {
            transform.position = new Vector3(-35, 131, 0);
        }
    }

}
