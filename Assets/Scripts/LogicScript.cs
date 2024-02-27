using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour {
    public int playerScore;
    public Text scoreText;
    [SerializeField] GameObject gameOverScene;

    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScene.SetActive(true);
    }

    public void RestartGame()
    {
        gameOverScene.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
