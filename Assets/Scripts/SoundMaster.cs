using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaster : MonoBehaviour
{
    [SerializeField] private AudioSource bgm_square1;
    [SerializeField] private AudioSource bgm_square2;
    [SerializeField] private AudioSource bgm_triangle;
    [SerializeField] private AudioSource bgm_noize;
    [SerializeField] private AudioSource se_square2;

    [SerializeField] private AudioClip SE01;

    void Start()
    {

    }

    void Update()
    {
        if (se_square2.isPlaying == true)
        {
            bgm_square2.volume = 0;
        }else if (se_square2.isPlaying == false)
        {
            bgm_square2.volume = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            se_square2.PlayOneShot(SE01);
        }
    }
}
