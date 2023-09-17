using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region variables

    public static int pScore;
    public static bool gameOver;
    
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    #endregion

    #region Unity Methods

    private void Start()
    {
        if (gameOver)
            gameOver = false;
        
        pScore = 0;
        Time.timeScale = 1;
    }

    private void Update()
    {
        //Set playerscore
        if (SceneManager.GetActiveScene().buildIndex == 1)
            scoreText.text = pScore.ToString();
        else
            return;
        
        //If ball passes the trigger area
        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
            
    }
    
    
    #endregion

    #region Methods

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    #endregion
}
