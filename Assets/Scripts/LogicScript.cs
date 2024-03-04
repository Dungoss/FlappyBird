using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour {
    public int playerScore;
    public Text scoreText;
    public Text highScoreText;
    [SerializeField] GameObject gameOverScene;
    public bool canAddScore = true;

    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = audioClip;

        loadHighScore(PlayerPrefs.GetInt("HighScore"));
    }

    public void setHighScore(int score)
    {
        if(PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("HighScore", score);         
        }

    }

    public void loadHighScore(int score)
    {
        highScoreText.text = score.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        if(canAddScore)
        {
            audioSource.Play();
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            
        }
    }

    public void GameOver()
    {
        canAddScore = false;
        gameOverScene.SetActive(true);
        setHighScore(playerScore);
    }

    public void RestartGame()
    {
        gameOverScene.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
