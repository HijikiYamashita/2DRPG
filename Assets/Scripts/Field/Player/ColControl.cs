using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColControl : MonoBehaviour
{
    public GameObject player;
    public int colNum;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "map" || col.gameObject.tag == "event" || col.gameObject.tag == "enemy")
        {
            player.GetComponent<PlayerController>().colTrigger(colNum);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.GetComponent<PlayerController>().colTrigger(0);
    }
}
