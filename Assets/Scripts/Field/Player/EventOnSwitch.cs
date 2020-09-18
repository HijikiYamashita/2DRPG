using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnSwitch : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject player;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "event")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                player.gameObject.GetComponent<PlayerController>().colTrigger(99);
                UI.SetActive(true);
                col.gameObject.GetComponent<EventControl>().eventSelect();
            }
        }
    }

    public void eventEnd()
    {
        UI.SetActive(false);
        player.gameObject.GetComponent<PlayerController>().colTrigger(0);
    }
}
