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

    
    public GameObject gameOverScreen;
    public TMP_Text finalScoreText;

    private int gameManagerPlayerScore = 0;

    private Vector2 playerStartPos;

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
        playerStartPos = player.transform.position;
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
        finalScoreText.text = "Score: " + playerScoreValue.ToString();
        gameOverScreen.SetActive(true);
    }

    public void DestroyAllPipes() 
    { 
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (GameObject pipe in pipes)
        {
            Destroy(pipe);
        }
    }
    public void ResetPlayerAndScore() { 
        player.transform.position = playerStartPos;
        playerScoreValue = 0;
    }
}
