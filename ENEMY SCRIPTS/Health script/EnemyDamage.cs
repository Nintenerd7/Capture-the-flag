using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyDamage : MonoBehaviour
{
    //variables
    public float HitPoints;
    public float maxHitPoints = 5;
    public Text EnemyScore;
    public Rigidbody EnemyBody;
    //

    void start()
    {
        HitPoints = maxHitPoints;
        EnemyBody = GetComponent<Rigidbody>();

    }

    public void TakeHit(float damage)
    {
        HitPoints -= damage;

        if (HitPoints <= 0)
        {
            Invoke("FallDown", 0.5f);//enemy rotates and falls 
            HighScore.ScorePoints += 15;//amount of points player gets After defeating the enemy. 
            EnemyScore.text = HighScore.ScorePoints.ToString("0");//adds score to the count
            Destroy(gameObject, 2f);//enemy is killed
        }
    }

    public void FallDown()
    {
        EnemyBody.isKinematic = false;
    }
}

