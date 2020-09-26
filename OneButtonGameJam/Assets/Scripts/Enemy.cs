using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float attack = 5.0f;
    [SerializeField] private float accuracy = 5.0f;
    [SerializeField] private float defence = 5.0f;
    [SerializeField] private float health = 100.0f;

    [SerializeField] private Fighter.Emotion emotion = Fighter.Emotion.neutral;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
