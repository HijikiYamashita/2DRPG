using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map99 : MonoBehaviour
{
    //eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();

    [SerializeField] private GameObject eventSwitch;
    int eventNum;
    int textNum = 0;
    bool eventTrue = false;

    void Start()
    {

    }

    void Update()
    {
        Debug.Log(eventNum);
        if (eventTrue == true)
        {
            if (TextDisplay.word.Length == TextDisplay.wordNum)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (eventNum == 1)
                    {
                        if (textNum == 1)
                        {
                            TextDisplay.word = new string[] { "\n", "＊", "「", "さ", "し", "す", "せ", "そ", "　", "た", "ち", "つ", "て", "と", "！", "\n" };
                            TextDisplay.wordNum = 0;
                            textNum++;
                        }
                        else if (textNum == 2)
                        {
                            eventEnd();
                        }
                    }
                    if (eventNum == 2)
                    {
                        if (textNum == 1)
                        {
                            TextDisplay.word = new string[] { "\n", "＊", "「", "ま", "み", "む", "め", "も", "　", "や", "　", "ゆ", "　", "よ", "！", "\n" };
                            TextDisplay.wordNum = 0;
                            textNum++;
                        }
                        else if (textNum == 2)
                        {
                            eventEnd();
                        }
                    }
                }
            }
        }
    }

    public void eventStart(int argEventNum)
    {
        eventTrue = true;
        if (argEventNum == 1)
        {
            textNum = 0;
            eventNum = 1;
            TextDisplay.word = new string[] { "\n", "＊", "「", "あ", "い", "う", "え", "お", "　", "か", "き", "く", "け", "こ", "！", "\n" };
            TextDisplay.wordNum = 0;
            textNum++;
        }
        if (argEventNum == 2)
        {
            textNum = 0;
            eventNum = 2;
            TextDisplay.word = new string[] { "\n", "＊", "「", "な", "に", "ぬ", "ね", "の", "　", "は", "ひ", "ふ", "へ", "ほ", "！", "\n" };
            TextDisplay.wordNum = 0;
            textNum++;
        }

        if (argEventNum == 3)
        {
            Debug.Log("イベント3");
        }
    }

    void eventEnd()
    {
        textNum = 0;
        eventNum = 0;
        eventTrue = false;
        TextDisplay.wordNum = 999;
        TextDisplay.textUI.text = "";
        eventSwitch.gameObject.GetComponent<EventOnSwitch>().eventEnd();
    }
}