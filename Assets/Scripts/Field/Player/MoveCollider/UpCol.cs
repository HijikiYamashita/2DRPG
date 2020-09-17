using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCol : MonoBehaviour
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
        player.GetComponent<PlayerController>().upMove = false;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.GetComponent<PlayerController>().upMove = true;
    }
}
