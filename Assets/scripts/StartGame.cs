using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadScene("game");
    }
    public void ClearHighScore()
    {
        PlayerPrefs.SetInt("highscore", 0);
        PlayerPrefs.Save();
    }
}
