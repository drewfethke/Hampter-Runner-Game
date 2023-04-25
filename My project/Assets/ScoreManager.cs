using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    int Count = 0;
    int highscore = 0;

    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = Count.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        Count += 1;
        scoreText.text = Count.ToString() + " POINTS";
        if (highscore > 0)
            PlayerPrefs.SetInt("Highscore", Count);
    }
}