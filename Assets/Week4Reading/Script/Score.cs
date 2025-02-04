using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject gameOverUI;
    public TextMeshProUGUI score;
    private int scoreVal = 0;
    private bool isPlaying = true;

    private void Start() {
        score.text = scoreVal.ToString();
        gameOverUI.SetActive(false);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            scoreVal++;
            score.text = scoreVal.ToString();
        }

        if (scoreVal > 20) {
            gameOverUI.SetActive(true);
            isPlaying = false;
            
        }

        if (!isPlaying && Input.GetKeyDown(KeyCode.Space)) {
            scoreVal = 0;
            score.text = scoreVal.ToString();
            gameOverUI.SetActive(false);
            isPlaying = true;
        }

        if (!isPlaying) {
            scoreVal = 0;
        }
    }

}
