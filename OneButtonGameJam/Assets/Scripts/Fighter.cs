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
    private readonly float criticalHitFactor = 2.0f;

    private string fighterName;

    private Fighter.Emotion emotion = Fighter.Emotion.neutral;
    private const int maxHealth = 100;
    public HealthBar healthBar;

    private GameObject activeItem;

    public GameObject[] items;

    private void Start()
    {
        health = maxHealth;
        if(healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    }

    public void StartFighter(float _attack, float _accuracy, float _defence, float _health, string _name)
    {
        attack = _attack;
        accuracy = _accuracy;
        defence = _defence;
        health = _health;
        fighterName = _name;

        items = new GameObject[3];
    }

    public float GetDefence()
    {
        return defence;
    }

    private float CalculateItemDamage(float attack, float itemDamage)
    {
        return Mathf.Max(((attack + itemDamage) / 2.0f), itemDamage);
    }

    public void GiveDamage(Fighter target)
    {
        float randomNumber = Random.Range(0.0f, 1.0f);

        if (randomNumber < (93.75f / 100)) // 6.25% chance of a critical hit
        {
            target.TakeDamage(criticalHitFactor * ((attack * attack) / (attack + target.GetDefence())));
        }
        else if (randomNumber < (accuracy / 100)) // accuracy% chance of a hit
        {
            target.TakeDamage((attack * attack) / (attack + target.GetDefence()));
        }
        else
        {
            // Miss
        }
    }

    public void GiveItemDamage(Fighter target)
    {
        Item item = activeItem.GetComponent<Item>();

        float itemDamage = CalculateItemDamage(attack, item.GetDamage());

        float randomNumber = Random.Range(0.0f, 1.0f);

        if (randomNumber < (93.75f / 100.0f)) // 6.25% chance of a critical hit
        {
            target.TakeDamage(criticalHitFactor * ((itemDamage * itemDamage) / (itemDamage + target.GetDefence())));
        }
        else if (randomNumber < (accuracy / 100.0f)) // accuracy% chance of a hit
        {
            target.TakeDamage((itemDamage * itemDamage) / (itemDamage + target.GetDefence()));
        }
        else
        {
            // Miss
        }
    }

    public string GetFighterName()
    {
        return fighterName;
    }

    public void TakeDamage(float damage)
    {
        health = Mathf.Max(health - damage, 0);
    }



}
