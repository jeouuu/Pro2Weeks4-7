using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    public AudioSource audSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            go.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (!audSource.isPlaying)
            {
                //audSource.Play();
                audSource.PlayOneShot(clip);
            }
    
            //audSource.clip.length

        }

    }
}
