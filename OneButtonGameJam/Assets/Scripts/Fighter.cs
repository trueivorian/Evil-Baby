using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Fighter : MonoBehaviour
{
    public enum Emotion { vhappy, happy, neutral, sad, vsad };

    private float attack;
    private float accuracy;
    private float defence;
    private float health;

    private const int maxHealth = 100;
    public HealthBar healthBar;


    //private Fighter.Emotion emotion = Fighter.Emotion.neutral;

    public GameObject[] items;

    private void Start()
    {
        health = maxHealth;
        if(healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    }

    public void StartFighter()
    {
        StartFighter(5.0f, 5.0f, 5.0f, 100.0f);
    }

    public void StartFighter(float _attack, float _accuracy, float _defence, float _health)
    {
        attack = _attack;
        accuracy = _attack;
        defence = _defence;
        health = _health;

        items = new GameObject[3];
        //items[0] = 

        
    }

    public void TakeDamage(float damage)
    {
        //we can add modifyers here according to emotion and the such 
        health -= damage;
        healthBar.SetHealth(health);
    }



}
