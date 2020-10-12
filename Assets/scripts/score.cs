using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    int Score = 0;
    int highscore;

    float height=0;

    public Text ScoreUI;
    public Text highscoreUI;


    
    public void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        highscoreUI.text = "Highscore " + highscore.ToString();
    }

    private void Update()
    {
        if(transform.position.y > height + 1)
        {
            Score += (int)(transform.position.y - height);
            height = transform.position.y;
            ScoreUI.text = "Score: " + Score.ToString();
        }
        if (Score > highscore)
        {
            highscore = Score;
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
            highscoreUI.text = "Highscore " + highscore.ToString();
        }

    }
}
