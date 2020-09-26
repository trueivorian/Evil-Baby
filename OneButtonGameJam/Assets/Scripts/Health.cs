using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int health = 100;


    public void Damage(int damage)
    {
        health = health - damage;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //animation, sound all that good shit 
        print("am ded");
        Destroy(gameObject);
    }
}
