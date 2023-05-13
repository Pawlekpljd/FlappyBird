using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public TMP_Text bestScore;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public AudioSource scoreAudio;
    public AudioSource dieAudio;
    public AudioSource hitAudio;
    public AudioSource flyAudio;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
        bestScore.text = "Best Score: " + PlayerPrefs.GetInt("BestScore", 0);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        dieAudio.Play();
        if (points > PlayerPrefs.GetInt("BestScore", 0))
        {
            PlayerPrefs.SetInt("BestScore", points);
        }
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        scoreAudio.Play();
        points++;
        scoreText.text = points.ToString();
    }



}
