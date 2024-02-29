using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour {
    public int playerScore;
    public Text scoreText;
    [SerializeField] GameObject gameOverScene;
    public bool canAddScore = true;

    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = audioClip;
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
    }

    public void RestartGame()
    {
        gameOverScene.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
