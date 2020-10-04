using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Fighter
{


    // Start is called before the first frame update
    void Start()
    {
        StartFighter();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("took damage");
            TakeDamage(20);
        }
    }




}
