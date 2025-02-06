using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    public AudioSource music;
    public AudioClip musicClip1;
    public AudioClip musicClip2;

  public void ChangeTrack(int value)
    {
        switch (value)
        {
            case 0: music.clip = musicClip1; break;
            case 1: music.clip = musicClip2; break;
        }
    }
}
