using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goaltrigger : MonoBehaviour
{
    public Goal GoalTrigger;

    void OnTriggerEnter(Collider other)
    {
        GoalTrigger.WinScreen();//activates win screen on collision 
    }
}
   
