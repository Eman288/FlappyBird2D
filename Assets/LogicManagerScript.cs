using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour 
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
	
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}