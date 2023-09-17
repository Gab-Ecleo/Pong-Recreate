using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    }

    private void Update()
    {
        //Set playerscore
        scoreText.text = pScore.ToString();
        
        //If ball passes the trigger area
        if (gameOver)
            gameOverPanel.SetActive(true);
    }
    
    
    #endregion

    #region Methods



    #endregion
}
