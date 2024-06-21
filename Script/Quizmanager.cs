using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizmanager : MonoBehaviour
{
  public GameObject[] Questions;

  int currentQuestion ;

  public void correctAnswer()
  {

      if(currentQuestion + 1 != Questions.Length)
      {
          Questions[currentQuestion].SetActive(false);

          currentQuestion++;
          Questions[currentQuestion].SetActive(true);
      }
  }
}
