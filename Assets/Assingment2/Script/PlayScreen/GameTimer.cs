using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Slider gameTimer;
    public float timerSpeed = 0.5f;
    public float t;

    public GameObject startUI;
    public GameObject playUI;
    public GameObject endUI;

    private void Start()
    {
        //set it off at the begginning
        playUI.SetActive(false);

        gameTimer.value = gameTimer.minValue;
    }

    private void Update()
    {
        Appear();
        StartGame();
        EndGame();
    }

    void Appear()
    {
        //check if the stertUI gameobject is on/off
        //if it's off turn on the playUI gameobject

        if (!startUI.activeSelf)
        {
            playUI.SetActive(true);
        }
    }

    void StartGame()
    {
        //set the gameTimer value = to the time count multiply by timerSpeed.
        //the timerSpeed in public so we can adjust the speed of the timer in the inspector.
        //only start counting when the playUI is on.

        if (playUI.activeSelf)
        {
            t += Time.deltaTime * timerSpeed;
            gameTimer.value = t;
        }
    }

    void EndGame()
    {
        if(gameTimer.value == gameTimer.maxValue)
        {
            endUI.SetActive(true );
        }
    }

}
