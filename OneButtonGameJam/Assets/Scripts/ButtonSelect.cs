using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{

    public GameObject[] buttons = new GameObject[] { }; // An array of the buttons cycled through in the option panel
    public float selectTime = 10f; // The length of time given for the player to select a button

    private int arrayLength;
    private GameObject selectedButton;
    private GameObject deselectedButton;
    public bool userSelected = false;



    // Start is called before the first frame update
    void Start()
    {
        arrayLength = buttons.Length;

        for(int i=0; i<arrayLength; i++)
        {
            buttons[i].GetComponent<Image>().color = Color.white;
        }

        StartCoroutine(ButtonCycle());

    }

    // Update is called once per frame
    void Update()
    {
        ChangeButtonColour();

        if(Input.anyKeyDown)
        {
            ButtonPressed();
        }
    }



    IEnumerator ButtonCycle()
    {

        for (int i = 0; i < arrayLength; i++)
        {
            selectedButton = buttons[i];

            yield return new WaitForSeconds(selectTime);
            if(i == arrayLength-1 )
            {
                i = -1;
            }
            deselectedButton = selectedButton;

        }
    }

    private void ChangeButtonColour()
    {
        if(userSelected)
        {
            selectedButton.GetComponent<Image>().color = Color.green;
        }
        else
        {
            selectedButton.GetComponent<Image>().color = new Color32(255, 165, 0, 255);
        }

        if (deselectedButton != null)
        {
            deselectedButton.GetComponent<Image>().color = Color.white;
        }

    }

    public void ButtonPressed()
    {
        userSelected = true;
        print(selectedButton);
        StopAllCoroutines();
    }

}
