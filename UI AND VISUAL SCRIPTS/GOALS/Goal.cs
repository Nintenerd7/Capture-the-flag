using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
   
    public GameObject ScoreBoard;//Scoreboard UI
    public Text HighScoreText;//shows overall score 
    public void WinScreen ()
    {
        Time.timeScale = 0;
        ScoreBoard.SetActive(true);//UI becomes active
        Pause.isPaused = true;
    }

   public void Transition()//button click 
    {
       
        SceneManager.LoadScene(2);//loads thank you scene
    }
}
