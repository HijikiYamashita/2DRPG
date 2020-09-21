using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map99 : MonoBehaviour
{
    //eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();

    [SerializeField] private GameObject eventSwitch;
    int publicEventNum;
    int textNum = 0;

    void Start()
    {

    }

    void Update()
    {
        Debug.Log(textNum);
        if (publicEventNum == 1)
        {
            if (TextDisplay.word.Length == TextDisplay.wordNum)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (textNum == 1)
                    {
                        TextDisplay.word = new string[] { "\n", "＊", "「", "さ", "し", "す", "せ", "そ", "\n", "\n", "　", "　", "た", "ち", "つ", "て", "と", "！", "\n" };
                        TextDisplay.wordNum = 0;
                        textNum++;
                    }else if (textNum == 2)
                    {
                        wait();
                    }
                }
            }
        }
    }

    public void eventStart(int eventNum)
    {
        if (eventNum == 1)
        {
            publicEventNum = 1;
            TextDisplay.word = new string[] { "\n", "＊", "「", "あ", "い", "う", "え", "お", "\n", "\n", "　", "　", "か", "き", "く", "け", "こ", "！", "\n" };
            TextDisplay.wordNum = 0;
            textNum++;
        }
        if (eventNum == 2)
        {
            Debug.Log("イベント2");
            Invoke("wait", 1);
        }

        if (eventNum == 3)
        {
            Debug.Log("イベント3");
        }
    }

    void wait()
    {
        eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();
    }
}