using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Item : MonoBehaviour
{
    public float damage;

    public Image icon;

    public float GetDamage()
    {
        return damage;
    }

}
