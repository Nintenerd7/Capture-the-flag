using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlimeCountOccurrance : MonoBehaviour
{
    //variables
    public static int SlimeCount { get; set; }
    public Text CountText;
    public Text ScoreText;
    //
    public void SlimesCollected()
    {
            SlimeCount++;
            HighScore.ScorePoints += 5;//adds 5 points to score board
            ScoreText.text = HighScore.ScorePoints.ToString("0");//shows score total. 
            CountText.text = SlimeCount.ToString("0");//shows how many slimes the player has collected. 
        
      

    }
}
