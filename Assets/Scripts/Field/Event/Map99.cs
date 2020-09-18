using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map99 : MonoBehaviour
{
    //eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();

    [SerializeField] private GameObject eventSwitch;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void eventStart(int eventNum)
    {
        if (eventNum == 1)
        {
            Debug.Log("イベント1");
            Invoke("wait", 2);
        }

        if (eventNum == 2)
        {
            Debug.Log("イベント2");
            Invoke("wait", 1);
        }
    }

    void wait()
    {
        eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();
    }
}
