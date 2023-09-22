using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIMovement : MonoBehaviour
{
    //variables
    public GameObject Slime;
    public float dist;

    public bool isTriggered;

    public NavMeshAgent _agent;
    // 

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Slime.transform.position, this.transform.position);//allows movement
        
        //distance
        if (dist <= 5)
        {
            isTriggered = true;
        }
        if (dist >= 5)
        {
            isTriggered = false;
        }
        //

        //if is triggered
        if (isTriggered)
        {
            _agent.isStopped = false;
            _agent.SetDestination(Slime.transform.position);
        }
        if (!isTriggered)
        {
            _agent.SetDestination(Slime.transform.position);
        }
        //
    }
}
