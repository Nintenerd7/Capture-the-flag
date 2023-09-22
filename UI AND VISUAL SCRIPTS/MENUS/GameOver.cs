using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
 public void PlayAgain()
    {
        SlimeCountOccurrance.SlimeCount = 0;//resets the count when the player dies
        HighScore.ScorePoints = 0;//resets the score after the player wins or dies  
        SceneManager.LoadScene(1);//loads level again 
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene(0);//loads title screen
    }
}
