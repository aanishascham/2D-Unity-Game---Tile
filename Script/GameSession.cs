using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] int score = 0;


    [SerializeField] TextMeshProUGUI livestext;
    [SerializeField] TextMeshProUGUI scoretext;
    void Awake()
    {
        int numGameSessions  = FindObjectsOfType<GameSession>().Length;
        if(numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void start()
    {
        livestext.text = playerLives.ToString();
        scoretext.text = score.ToString();
    }

  
    public void ProcessPlayerDeath()
    {
        if(playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoretext.text = score.ToString();
    }


    void TakeLife()
    {
        playerLives--;
        int currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livestext.text = playerLives.ToString();
    }

    void ResetGameSession()
    {
        FindObjectOfType<ScenePersist>().ResetScenePersist();
        SceneManager.LoadScene(0);//quiz here
        Destroy(gameObject);
    }
}
