using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCollection : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        SlimeCountOccurrance SlimeCO = other.GetComponent<SlimeCountOccurrance>();//gets slime count from count occurance class 

        if (SlimeCO != null)
        {
            SlimeCO.SlimesCollected();//collects the slime 
            Destroy(gameObject);//disapears after collection
        }
    }
 
}
