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

    public AudioClip audioClip; // Declare it as AudioClip, not AudioSource

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        // Assign the AudioClip to the AudioSource
        audioSource.clip = audioClip;

        // Play the audio

    }


    public void AddScore(int scoreToAdd)
    {
        if(canAddScore)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            audioSource.Play();
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
