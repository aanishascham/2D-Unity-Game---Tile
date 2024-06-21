using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slides : MonoBehaviour
{
    public void Play()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToMainMenu()
     {
      SceneManager.LoadScene("MENU");
     }

     public void GoToQuiz()
     {
         SceneManager.LoadScene("Quiz1");
     }
}
