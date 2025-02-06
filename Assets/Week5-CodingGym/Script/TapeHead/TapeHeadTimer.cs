using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapeHeadTimer : MonoBehaviour
{
    public Slider timer;
    public AudioSource music;

    private void Start()
    {
        timer.maxValue = music.clip.length;
        timer.value = music.clip.length;
    }

    private void Update()
    {
        if (music.isPlaying)
        {
            timer.value = music.clip.length - music.time;
        }
    }


}
