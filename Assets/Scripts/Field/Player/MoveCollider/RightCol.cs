using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCol : MonoBehaviour
{
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        player.GetComponent<PlayerController>().rightMove = false;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.GetComponent<PlayerController>().rightMove = true;
    }
}
