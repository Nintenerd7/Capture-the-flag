using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collision")
        {
            Destroy(gameObject);//destroys object after collision
        }
        if (other.gameObject.tag == "Enemy")
        {
            var enemy = other.GetComponent<EnemyDamage>();//gets class enemy damage
            if (enemy)
            {
                enemy.TakeHit(1);//enemy takes a hit from the bullet
            }
            Destroy(gameObject);//destroys object after collision
        }
    }
}
