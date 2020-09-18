using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventControl : MonoBehaviour
{
    public int mapNum;
    public int eventNum;

    GameObject eventMaster;

    void Start()
    {
        eventMaster = GameObject.Find("EventMaster");
    }

    void Update()
    {
        
    }

    public void eventSelect()
    {
        if (mapNum == 99)
        {
            eventMaster.gameObject.GetComponent<Map99>().eventStart(eventNum);
        }
    }
}
