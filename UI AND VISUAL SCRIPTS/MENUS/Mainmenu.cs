using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
  public void play()
    {
        SlimeCountOccurrance.SlimeCount = 0;//resets the count when the player dies
        HighScore.ScorePoints = 0;//resets the score after the player wins or dies       
        SceneManager.LoadScene(1);//loads level 
    }

    public void quit()
    {
        Application.Quit();//exits the game 
    }
}
