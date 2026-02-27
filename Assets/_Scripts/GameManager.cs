using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameObject player;
    public TMP_Text playerScore;
    //public TMP_Text playerHighScore;

    public int gameOverPageIndex = 0;
    public GameObject gameOverScreen;

    private int gameManagerPlayerScore = 0;

    public static int playerScoreValue
    {
        get
        {
            return Instance.gameManagerPlayerScore;
        }
        set
        {
            Instance.gameManagerPlayerScore = value;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore(); //EZT MAJD LEHET EGY UI MANAGERBE ATRAKNI
    }

    public void ScorePoint()
    {
        playerScoreValue++;
    }

    public void UpdateScore()
    {
               playerScore.text = playerScoreValue.ToString();
    }

    public void GameOver() 
    {        
        Debug.Log("Game Over!");
        Time.timeScale = 0f; 
        Instantiate(gameOverScreen, Vector3.zero, Quaternion.identity);
    }
}
