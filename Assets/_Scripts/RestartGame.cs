using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button restartButton;
    void Start()
    {
        restartButton.onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        GameManager.Instance.ResetPlayerAndScore();
        GameManager.Instance.DestroyAllPipes();
        GameManager.Instance.gameOverScreen.SetActive(false);
        Time.timeScale = 1f;
    }



}
