using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldSoundMaster : MonoBehaviour
{
    [SerializeField] private AudioSource as1;
    [SerializeField] private AudioSource as2;
    [SerializeField] private AudioSource as3;
    [SerializeField] private AudioSource as4;

    public AudioClip SE01;

    void Start()
    {

    }

    void Update()
    {
        if (as4.isPlaying == false)
        {
            as2.volume = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            as2.volume = 0;
            as4.PlayOneShot(SE01);
        }
    }
}
