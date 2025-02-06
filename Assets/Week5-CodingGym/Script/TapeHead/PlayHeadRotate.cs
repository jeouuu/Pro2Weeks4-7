using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHeadRotate : MonoBehaviour
{
    float rotation;
    public AudioSource music;

    private void Update()
    {
        

        if(music.isPlaying)
        {
            rotateStart();
        } else
        {
            rotateStop();
        }
    }

    public void rotateStart()
    {
        Vector3 rot = transform.eulerAngles;
        rotation = 1;
        rot.z += rotation;
        transform.eulerAngles = rot;
    }

    public void rotateStop()
    {
        Vector3 rot = transform.eulerAngles;
        rotation = 0;
        rot.z += rotation;
        transform.eulerAngles = rot;
    }

    public bool isRotate()
    {
        return true;
    }
}
