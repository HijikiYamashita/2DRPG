using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnSwitch : MonoBehaviour
{
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
                //イベント処理を書く
            }
        }
    }
}
