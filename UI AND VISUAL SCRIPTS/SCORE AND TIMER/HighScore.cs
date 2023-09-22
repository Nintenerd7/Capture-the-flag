using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    [SerializeField] Text ScoreCount;//stores points collected
    [SerializeField] Text OveralScore;//high score in total after player finsihes leve;
    public static float ScorePoints;

    // Update is called once per frame
    void Update()
    {
        //when player reaches the goal they will get a high score. 
        ScoreCount.text = ScorePoints.ToString("0");
  
    }
}
