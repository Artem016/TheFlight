using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseWindow;
    public static GameManager instance;
    
    void Start()
    {
        instance = this;
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        loseWindow.SetActive(true);
        Time.timeScale = 0;
        
        ScoreManager.Instance.PlayerLose();
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
