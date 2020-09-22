using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public static string[] word;
    public static Text textUI;
    public static int wordNum = 999;
    float timer;
    public float speed;

    void Start()
    {
        textUI = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (word.Length != wordNum)
        {
            if (timer >= speed)
            {
                textUI.text += word[wordNum];
                wordNum++;
                timer = 0;
            }
        }
    }
}