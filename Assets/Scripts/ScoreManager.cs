using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; set; }
    [SerializeField] private TextMeshProUGUI scoreOnGame;
    [SerializeField] private TextMeshProUGUI scoreThis;
    [SerializeField] public TextMeshProUGUI scoreBest;
    [SerializeField] public Medal[] medals;
    [SerializeField] public Image medalOnScreen;
    private int score;

    private void Start()
    {
        Instance = this;
        scoreOnGame.text = "0";
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreOnGame.text = this.score.ToString();
        scoreThis.text = this.score.ToString();
    }

    public void PlayerLose()
    {
        int score = this.score;
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (score > bestScore)
        {
            bestScore = score;
        }

        for (int i = 0; i < medals.Length; i++)
        {
            if (medals[i].needScore <= this.score)
            {
                medalOnScreen.sprite = medals[i].medalSpr;
            }
        }

        scoreBest.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
