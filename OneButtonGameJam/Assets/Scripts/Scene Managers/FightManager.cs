using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    private GameObject dialogue;
    private GameObject option1;
    private GameObject option2;
    private GameObject option3;
    private GameObject option4;
    private GameObject player;
    private GameObject enemy;

    private bool firstFrame = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.FindGameObjectWithTag("Dialogue");
        option1 = GameObject.FindGameObjectWithTag("Option1");
        option2 = GameObject.FindGameObjectWithTag("Option2");
        option3 = GameObject.FindGameObjectWithTag("Option3");
        option4 = GameObject.FindGameObjectWithTag("Option4");
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (!firstFrame)
        {
            StartFight();
            firstFrame = true;
        }
    }

    private void StartFight()
    {
        dialogue.GetComponent<Text>().text = "What will " + player.GetComponent<Player>().GetFighterName() + " do?";
        option1.GetComponent<Text>().text = "Fight";
        option2.GetComponent<Text>().text = "Toys";
        option4.GetComponent<Text>().text = "Mum/Dad";
        option3.GetComponent<Text>().text = "Crawl";

    }
}
