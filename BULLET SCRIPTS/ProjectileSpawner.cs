using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProjectileSpawner : MonoBehaviour
{
    public Rigidbody projectile;//rigidbody of the projectile
    public GameObject Prefab;//gameobject 
    public Transform FirePoint;//pivot point
    public static Rigidbody clone;//cloning body
    public Text AmmoUpdate;//text 
 
    void Update()
    {
        if (!Pause.isPaused)//if player does not press pause OR the player has not won yet 
        {
            if (Input.GetMouseButtonDown(0))//mouse press
            {
                if (SlimeCountOccurrance.SlimeCount > 0)//if player has more than one slime
                {

                    Prefab.SetActive(true);//activates prefab

                    //takes away a number after the player shoots one bullet
                    SlimeCountOccurrance.SlimeCount--;
                    //

                    shoot();//shoots 

                    updateText();//updates Hud text 

                }//end if 
                else
                {

                    Prefab.SetActive(false); //player will not shoot out any bullets
                }//end else

            }//end if 
        }//end if 
  
    }


    void shoot()//contains logic for the shooting command
    {
        //shoot
        clone = (Rigidbody)Instantiate(projectile, FirePoint.position, projectile.rotation);//shoots projectile

        clone.velocity = FirePoint.TransformDirection(Vector3.forward * 20);//allows player to shoot more than one bullet 
    }
    void updateText()//contains UI logic for when the number of slime balls are changed. 
    {
        AmmoUpdate.text = SlimeCountOccurrance.SlimeCount.ToString("0");
    }
}
